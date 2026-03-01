using System.Collections;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using BepInEx.Unity.IL2CPP.Utils;
using TheOtherRoles.Utilities;
using UnityEngine;
using UnityEngine.Networking;
using static TheOtherRoles.Modules.CustomHats.CustomHatManager;

namespace TheOtherRoles.Modules.CustomHats;

public class HatsLoader : MonoBehaviour
{
    private bool isRunning;
    private static readonly HttpClient Http = new HttpClient();

    public void FetchHats()
    {
        if (isRunning) return;
        TheOtherRolesPlugin.Logger.LogMessage($"[TOR DEBUG] HatsLoader active (HttpClient download) dir={HatsDirectory}");
        this.StartCoroutine(CoFetchHats());
    }

    [HideFromIl2Cpp]
    private IEnumerator CoFetchHats()
    {
        isRunning = true;
        var www = new UnityWebRequest();
        www.SetMethod(UnityWebRequest.UnityWebRequestMethod.Get);
        TheOtherRolesPlugin.Logger.LogMessage($"Download manifest at: {RepositoryUrl}/{ManifestFileName}");
        www.SetUrl($"{RepositoryUrl}/{ManifestFileName}");
        www.downloadHandler = new DownloadHandlerBuffer();
        var operation = www.SendWebRequest();

        while (!operation.isDone)
        {
            yield return new WaitForEndOfFrame();
        }

        if (www.isNetworkError || www.isHttpError)
        {
            TheOtherRolesPlugin.Logger.LogError(www.error);
            yield break;
        }

        var response = JsonSerializer.Deserialize<SkinsConfigFile>(www.downloadHandler.text, new JsonSerializerOptions
        {
            AllowTrailingCommas = true
        });
        www.downloadHandler.Dispose();
        www.Dispose();

        if (!Directory.Exists(HatsDirectory)) Directory.CreateDirectory(HatsDirectory);

        UnregisteredHats.AddRange(SanitizeHats(response));
        var toDownload = GenerateDownloadList(UnregisteredHats);
        if (EventUtility.isEnabled) UnregisteredHats.AddRange(CustomHatManager.loadHorseHats());

        TheOtherRolesPlugin.Logger.LogMessage($"I'll download {toDownload.Count} hat files");

        foreach (var fileName in toDownload)
        {
            yield return CoDownloadHatAsset(fileName);
        }

        isRunning = false;
    }

    private static IEnumerator CoDownloadHatAsset(string fileName)
    {
        fileName = fileName.Replace(" ", "%20");
        TheOtherRolesPlugin.Logger.LogMessage($"downloading hat: {fileName}");
        TheOtherRolesPlugin.Logger.LogMessage($"[TOR DEBUG] HatsLoader downloading via HttpClient: {fileName}");
        var url = $"{RepositoryUrl}/hats/{fileName}";

        var filePath = Path.Combine(HatsDirectory, fileName);
        filePath = filePath.Replace("%20", " ");
        var tmpPath = filePath + ".download";
        if (File.Exists(tmpPath)) File.Delete(tmpPath);

        var task = Http.GetByteArrayAsync(url);
        while (!task.IsCompleted)
        {
            yield return new WaitForEndOfFrame();
        }

        if (task.Exception != null)
        {
            TheOtherRolesPlugin.Logger.LogError(task.Exception.Message);
            yield break;
        }

        byte[] bytes = task.Result;
        File.WriteAllBytes(tmpPath, bytes);
        if (File.Exists(filePath)) File.Delete(filePath);
        File.Move(tmpPath, filePath);
    }
}