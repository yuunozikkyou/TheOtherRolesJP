using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using Object = UnityEngine.Object;
using TheOtherRoles.Patches;
using UnityEngine.SceneManagement;
using TheOtherRoles.Utilities;
using AmongUs.Data;
using Assets.InnerNet;
using System.Linq;

namespace TheOtherRoles.Modules {
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public class MainMenuPatch {
        private static bool horseButtonState = TORMapOptions.enableHorseMode;
        //private static Sprite horseModeOffSprite = null;
        //private static Sprite horseModeOnSprite = null;
        private static AnnouncementPopUp popUp;

        private static void Prefix(MainMenuManager __instance) {
            var template = GameObject.Find("ExitGameButton");
            var template2 = GameObject.Find("CreditsButton");
            if (template == null || template2 == null) return;
            template.transform.localScale = new Vector3(0.42f, 0.84f, 0.84f);
            template.GetComponent<AspectPosition>().anchorPoint = new Vector2(0.625f, 0.5f);
            template.transform.FindChild("FontPlacer").transform.localScale = new Vector3(1.8f, 0.9f, 0.9f);
            template.transform.FindChild("FontPlacer").transform.localPosition = new Vector3(-1.1f, 0f, 0f);

            template2.transform.localScale = new Vector3(0.42f, 0.84f, 0.84f);
            template2.GetComponent<AspectPosition>().anchorPoint = new Vector2(0.378f, 0.5f);
            template2.transform.FindChild("FontPlacer").transform.localScale = new Vector3(1.8f, 0.9f, 0.9f);
            template2.transform.FindChild("FontPlacer").transform.localPosition = new Vector3(-1.1f, 0f, 0f);



            var buttonDiscord = UnityEngine.Object.Instantiate(template, template.transform.parent);
            buttonDiscord.transform.localScale = new Vector3(0.42f, 0.84f, 0.84f);
            buttonDiscord.GetComponent<AspectPosition>().anchorPoint = new Vector2(0.542f, 0.5f);

            var textDiscord = buttonDiscord.transform.GetComponentInChildren<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.5f, new System.Action<float>((p) => {
                textDiscord.SetText("TORJP Discord");
            })));
            PassiveButton passiveButtonDiscord = buttonDiscord.GetComponent<PassiveButton>();
            
            passiveButtonDiscord.OnClick = new Button.ButtonClickedEvent();
            passiveButtonDiscord.OnClick.AddListener((System.Action)(() => Application.OpenURL("https://discord.gg/yBuPQGahha")));


            
            // TOR credits button
            if (template == null) return;
            var creditsButton = Object.Instantiate(template, template.transform.parent);

            creditsButton.transform.localScale = new Vector3(0.42f, 0.84f, 0.84f);
            creditsButton.GetComponent<AspectPosition>().anchorPoint = new Vector2(0.462f, 0.5f);

            var textCreditsButton = creditsButton.transform.GetComponentInChildren<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.5f, new System.Action<float>((p) => {
                textCreditsButton.SetText("TOR+TORJP Credits");
            })));
            PassiveButton passiveCreditsButton = creditsButton.GetComponent<PassiveButton>();

            passiveCreditsButton.OnClick = new Button.ButtonClickedEvent();

            passiveCreditsButton.OnClick.AddListener((System.Action)delegate {
                // do stuff
                if (popUp != null) Object.Destroy(popUp);
                var popUpTemplate = Object.FindObjectOfType<AnnouncementPopUp>(true);
                if (popUpTemplate == null) {
                    TheOtherRolesPlugin.Logger.LogError("couldnt show credits, popUp is null");
                    return;
                }
                popUp = Object.Instantiate(popUpTemplate);

                popUp.gameObject.SetActive(true);
                string creditsString = @$"<align=""center""><b>TORJP開発者、翻訳者:</b>
翻訳者:ゆうの実況 開発者:ゆうの実況(ゆうの実況のチャンネル登録よろしくね![https://youtube.com/@yuunozikkyou]youtube[])
                <b>本家TORチーム:</b>
Mallöris    K3ndo    Bavari    Gendelo

<b>元チームメンバー:</b>
Eisbison (GOAT)    Thunderstorm584    EndOfFile

<b>追加開発者:</b>
EnoPM    twix    NesTT

<b>Githubの貢献者:</b>
Alex2911    amsyarasyiq    MaximeGillot
Psynomit    probablyadnf    JustASysAdmin

<b>[https://discord.gg/yBuPQGahha]Discord[] モデレーター:</b>
Draco Cordraconis    Streamblox (formerly)
discordのヘルパーの皆さん、ありがとうございました！

miniduikbootとGDに感謝します。
TheOtherRoles 4.5.2更新　3月13日
TheOtherRoles JP1.0.8更新　5月11
";
                creditsString += $@"<size=60%> <b>その他のクレジットとリソース:</b>
OxygenFilter - v2.3.0からv2.6.1まで、自動難読化処理にOxygenFilterを使用していました。
Reactor - v2.0.0以前のすべてのバージョン、そして4.2.0以降で使用されているフレームワーク。
BepInEx - ゲーム関数をフックするために使用。
Essentials - DorCoMaNdOによるカスタムゲームオプション：
v1.6以前: デフォルトのEssentialsリリースを使用。
v1.6-v1.8：デフォルトのEssentialsを少し変更しました。
v2.0.0以降： Reactorを使用しなくなったため、DorCoMaNdOのものにインスパイアされた独自の実装を使用しています。
ジャッカルとサイドキック - ジャッカルとサイドキックのオリジナル・アイデアはDhalucardによるものです。
Among-Us-Love-Couple-Mod - LoversモディファイアのアイデアはWoody-devから。
Jester - JesterロールのアイデアはMaartiiから。
ExtraRolesAmongUs - エンジニアとメディックのロールのアイディアはNotHunter101から。また、彼らの実装からいくつかのコードスニペットを使用しました。
Among-Us-Sheriff-Mod - 保安官のアイディアはWoody-devから。
TooManyRolesMods - DetectiveとTime MasterのアイデアはHardel-DWから。また、Hardel-DWの実装のコード・スニペットも使われました。
TownOfUs - Swapper、Shifter、Arsonistと同様のMayorのアイデアはSlushiegooseから。
Ottomated - Morphling、Snitch、CamouflagerロールのアイデアはOttomatedから。
Crowded-Mod - 10人以上のロビーの実装はCrowded Mod Teamのものにインスパイアされました。
Goose-Goose-Duck - ハゲタカ役のアイディアはSlushiegooseから。
TheEpicRoles - LaicosVK DasMonschta Novaによるファーストキルシールドのアイデア（一部）とタブオプションメニューのアイデア（一部＋コード）。
ugackMiner53 - Prop Hunt ゲームモードのアイデアとコアコード。</size>";

                Assets.InnerNet.Announcement creditsAnnouncement = new() {
                    Id = "torCredits",
                    Language = 0,
                    Number = 500,
                    Title = "The Other Roles\nCredits & Resources",
                    ShortTitle = "TOR Credits",
                    SubTitle = "",
                    PinState = false,
                    Date = "01.07.2021",
                    Text = creditsString,
                };
                __instance.StartCoroutine(Effects.Lerp(0.1f, new Action<float>((p) => {
                    if (p == 1) {
                        var backup = DataManager.Player.Announcements.allAnnouncements;
                        DataManager.Player.Announcements.allAnnouncements = new();
                        popUp.Init(false);
                        DataManager.Player.Announcements.SetAnnouncements(new Announcement[] { creditsAnnouncement });
                        popUp.CreateAnnouncementList();
                        popUp.UpdateAnnouncementText(creditsAnnouncement.Number);
                        popUp.visibleAnnouncements._items[0].PassiveButton.OnClick.RemoveAllListeners();
                        DataManager.Player.Announcements.allAnnouncements = backup;
                    }
                })));
            });
            
        }

        public static void addSceneChangeCallbacks() {
            SceneManager.add_sceneLoaded((Action<Scene, LoadSceneMode>)((scene, _) => {
                if (!scene.name.Equals("MatchMaking", StringComparison.Ordinal)) return;
                TORMapOptions.gameMode = CustomGamemodes.Classic;
                // Add buttons For Guesser Mode, Hide N Seek in this scene.
                // find "HostLocalGameButton"
                var template = GameObject.FindObjectOfType<HostLocalGameButton>();
                var gameButton = template.transform.FindChild("CreateGameButton");
                var gameButtonPassiveButton = gameButton.GetComponentInChildren<PassiveButton>();

                var guesserButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                guesserButton.transform.localPosition += new Vector3(0f, -0.5f);
                var guesserButtonText = guesserButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var guesserButtonPassiveButton = guesserButton.GetComponentInChildren<PassiveButton>();
                
                guesserButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                guesserButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    TORMapOptions.gameMode = CustomGamemodes.Guesser;
                    template.OnClick();
                }));

                var HideNSeekButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                HideNSeekButton.transform.localPosition += new Vector3(1.7f, -0.5f);
                var HideNSeekButtonText = HideNSeekButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var HideNSeekButtonPassiveButton = HideNSeekButton.GetComponentInChildren<PassiveButton>();
                
                HideNSeekButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                HideNSeekButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    TORMapOptions.gameMode = CustomGamemodes.HideNSeek;
                    template.OnClick();
                }));

                var PropHuntButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                PropHuntButton.transform.localPosition += new Vector3(3.4f, -0.5f);
                var PropHuntButtonText = PropHuntButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var PropHuntButtonPassiveButton = PropHuntButton.GetComponentInChildren<PassiveButton>();

                PropHuntButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                PropHuntButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    TORMapOptions.gameMode = CustomGamemodes.PropHunt;
                    template.OnClick();
                }));

                template.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                    guesserButtonText.SetText("TOR Guesser");
                    HideNSeekButtonText.SetText("TOR Hide N Seek");
                    PropHuntButtonText.SetText("TOR Prop Hunt");
                })));
            }));
        }
    }
}
