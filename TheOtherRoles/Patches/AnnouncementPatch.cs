using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AmongUs.Data;
using AmongUs.Data.Player;
using Assets.InnerNet;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using BepInEx.Unity.IL2CPP.Utils.Collections;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;
//TOH_Yのプログラムを借りました。
namespace TheOtherRoles.Patches 
{
    public class ModNewsData
    {
        public int Number;
        public int BeforeNumber;
        public string Title;
        public string SubTitle;
        public string ShortTitle;
        public string Text;
        public string Date;

        public Announcement ToAnnouncement()
        {
            var result = new Announcement
            {
                Number = Number,
                Title = Title,
                SubTitle = SubTitle,
                ShortTitle = ShortTitle,
                Text = Text,
                Language = (uint)DataManager.Settings.Language.CurrentLanguage,
                Date = Date,
                Id = "ModNews"
            };

            return result;
        }
    }

    [HarmonyPatch]
    public class ModNews
    {
    public static List<ModNews> AllModNews = new();
    public int Number;
    public int BeforeNumber;
    public string Title;
    public string SubTitle;
    public string ShortTitle;
    public string Text;
    public string Date;
    public ModNews(int Number, string Title, string SubTitle, string ShortTitle,
        string Text, string Date)
    {
        this.Number = Number;
        this.Title = Title;
        this.SubTitle = SubTitle;
        this.ShortTitle = ShortTitle;
        this.Text = Text;
        this.Date = NormalizeDateString(Date);
        AllModNews.Add(this);
    }

    public Announcement ToAnnouncement()
    {
        var result = new Announcement
        {
            Number = Number,
            Title = Title,
            SubTitle = SubTitle,
            ShortTitle = ShortTitle,
            Text = Text,
            Language = (uint)DataManager.Settings.Language.CurrentLanguage,
            Date = Date,
            Id = "ModNews"
        };

        return result;
    }

    public const string ModNewsURL = "https://raw.githubusercontent.com/yuunozikkyou/TheOtherRolesJP/main/News.json";
    static bool downloaded = false;
    static bool fetching = false;

    private static DateTime ParseDateSafe(string s) {
        if (DateTime.TryParse(s, out var dt)) return dt;
        return DateTime.MinValue;
    }

    private static string NormalizeDateString(string s) {
        if (DateTime.TryParse(s, out var dt)) {
            return dt.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }
        return s;
    }

    private static IEnumerator FetchNews()
    {
        if (downloaded)
        {
            yield break;
        }
        if (fetching) {
            while (fetching) yield return null;
            yield break;
        }
        fetching = true;

        // まずはオンラインの JSON を取得
        var request = UnityWebRequest.Get(ModNewsURL);
        request.timeout = 10;
        yield return request.SendWebRequest();
        string jsonText = null;
        if (!request.isNetworkError && !request.isHttpError)
        {
            jsonText = request.downloadHandler.text;
        }
        else
        {
            // 失敗した場合はローカルの News.json (MOD DLL と同じフォルダ) をフォールバックで読む
            try
            {
                var asmPath = System.IO.Path.GetDirectoryName(typeof(TheOtherRolesPlugin).Assembly.Location);
                var localPath = System.IO.Path.Combine(asmPath ?? "", "News.json");
                if (System.IO.File.Exists(localPath))
                {
                    jsonText = System.IO.File.ReadAllText(localPath);
                }
            }
            catch
            {
                fetching = false;
                yield break;
            }
        }

        if (string.IsNullOrWhiteSpace(jsonText))
        {
            fetching = false;
            yield break;
        }

        try {
            AllModNews.Clear();
            var json = JObject.Parse(jsonText);
            var newsRoot = json["News"];
            if (newsRoot != null) {
                for (var news = newsRoot.First; news != null; news = news.Next)
                {
                    _ = new ModNews(
                        int.Parse(news["Number"]?.ToString() ?? "0"),
                        news["Title"]?.ToString(),
                        news["Subtitle"]?.ToString(),
                        news["Short"]?.ToString(),
                        news["Body"]?.ToString(),
                        news["Date"]?.ToString());
                }
            }
            downloaded = AllModNews.Count > 0;
        } catch {
            downloaded = false;
        }
        fetching = false;
    }

    /// <summary>
    /// 既存のポップアップ初期化に ModNews 取得コルーチンを前置する
    /// </summary>
    [HarmonyPatch(typeof(AnnouncementPopUp), nameof(AnnouncementPopUp.Init)), HarmonyPostfix]
    public static void Initialize(ref Il2CppSystem.Collections.IEnumerator __result)
    {
        __result = Effects.Sequence(FetchNews().WrapToIl2Cpp(), __result);
    }

    /// <summary>
    /// メインメニュー起動時にも事前に ModNews を取得しておく
    /// </summary>
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start)), HarmonyPostfix]
    public static void PreloadNewsOnMainMenu(MainMenuManager __instance)
    {
        __instance.StartCoroutine(FetchNews().WrapToIl2Cpp());
    }
    [HarmonyPatch(typeof(PlayerAnnouncementData), nameof(PlayerAnnouncementData.SetAnnouncements)), HarmonyPrefix]
    public static bool SetModAnnouncements(PlayerAnnouncementData __instance, [HarmonyArgument(0)] ref Il2CppReferenceArray<Announcement> aRange)
    {
        AllModNews.Sort((a1, a2) => DateTime.Compare(ParseDateSafe(a2.Date), ParseDateSafe(a1.Date)));

        List<Announcement> FinalAllNews = new();
        AllModNews.Do(n => FinalAllNews.Add(n.ToAnnouncement()));
        foreach (var news in aRange)
        {
            if (!AllModNews.Any(x => x.Number == news.Number))
                FinalAllNews.Add(news);
        }
        FinalAllNews.Sort((a1, a2) => DateTime.Compare(ParseDateSafe(a2.Date), ParseDateSafe(a1.Date)));

        aRange = new(FinalAllNews.Count);
        for (int i = 0; i < FinalAllNews.Count; i++)
            aRange[i] = FinalAllNews[i];

        return true;
    }

    [HarmonyPatch(typeof(AnnouncementPanel), nameof(AnnouncementPanel.SetUp)), HarmonyPostfix]
    public static void SetUpPanel(AnnouncementPanel __instance, [HarmonyArgument(0)] Announcement announcement)
    {
        if (announcement.Number < 100000) return;
        var obj = new GameObject("ModLabel");
        obj.layer = -1;
        obj.transform.SetParent(__instance.transform);
        obj.transform.localPosition = new Vector3(-0.8f, 0.18f, 0.5f);
        obj.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        var renderer = obj.AddComponent<SpriteRenderer>();
        renderer.sprite = Helpers.loadSpriteFromResources($"TheOtherRoles.Resources.ModNews.png", 350f);
        renderer.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
    }
}
}