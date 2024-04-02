using HarmonyLib;
using TheOtherRoles;

namespace TheOtherRoles.Modules.CustomHats.Patches;

[HarmonyPatch(typeof(CosmeticsCache))]
internal static class CosmeticsCachePatches
{
    [HarmonyPatch(nameof(CosmeticsCache.GetHat))]
    [HarmonyPrefix]
    private static bool GetHatPrefix(string id, ref HatViewData __result)
    {
        TheOtherRolesPlugin.Logger.LogMessage($"コスメティック・キャッシュから帽子{id}をロードしようとしている");
        return !CustomHatManager.ViewDataCache.TryGetValue(id, out __result);
    }
}