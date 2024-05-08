using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;
using System.Threading.Tasks;
using System.Net.Http;

namespace TheOtherRoles
{
    public class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        public RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        //public static RoleInfo homeguard = new RoleInfo("自宅警備員",Homeguard.color, "船をまもらなきゃ!!\nタスク?ナニソレオイシイノ?", "タスク?ナニソレオイシイノ?", RoleId.Homeguard);

        public static RoleInfo jester = new RoleInfo("ジェスター", Jester.color, "投票で吊られよう", "投票で吊られよう", RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo("メイヤー", Mayor.color, "不思議な力によりあなたの票が多くカウントされる!!", "あなたの票は多くカウントされる", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("ポータルメーカー", Portalmaker.color, "ポータルを設置してクルーの役に立とう", "ポータルを作成しよう", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("エンジニア",  Engineer.color, "船内の重要なシステムを維持しよう", "船を修理する", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("シェリフ", Sheriff.color, "<color=#FF1919FF>人外</color>をぶち殺そう", "人外を殺す", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("代理人", Sheriff.color, "<color=#FF1919FF>インポスター</color>に手錠をかけよう", "インポスターに手錠をかける", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("ライター", Lighter.color, "あなたの光は決して消えない", "あなたの光は決して消えない", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("ゴットファーザー", Godfather.color, "すべてのクルーを殺害しよう", "すべてのクルーを殺害しよう", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("マフィア", Mafioso.color, "<color=#FF1919FF>マフィア</color>と協力して、クルーをキルしよう", "すべてのクルーを殺害しよう", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("ジャニター", Janitor.color, "死体を隠して <color=#FF1919FF>マフィア</color> と協力する", "死体を隠す", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("モーフィング", Morphling.color, "違います!!あの人が犯人です!!", "変身する", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("カモフラージャー", Camouflager.color, "誰かわからないよ...", "誰かわからなくしよう", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("ヴァンパイア", Vampire.color, "クルーに噛みつこう", "クルーに噛みつく", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("イレイサー", Eraser.color, "あれ？私の役職はどこに？", "クルーの役職を消去する", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("トリックスター", Trickster.color, "ジャック・イン・ザ・ボックスを使ってクルーを驚かせよう", "クルーを驚かせる", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("クリーナー", Cleaner.color, "死体なんてなかった、いいね？", "死体を片付ける", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("魔術師", Warlock.color, "クルーを呪い、キルしよう", "みんなを呪って、殺す", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("バウンティーハンター", BountyHunter.color, "賞金首を狙おう", "賞金首を狙おう", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("探偵", Detective.color, "足跡を調べて <color=#FF1919FF>人外</color> を見つけよう", "足跡を調べる", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("タイムマスター", TimeMaster.color, "タイムシールドを使って身を守ろう...", "タイムシールドを使う", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("メディック", Medic.color, "盾で誰かを守る", "盾で誰かを守る", RoleId.Medic);
        public static RoleInfo madmate = new RoleInfo("マッドメイト",Madmate.color,"インポスターの手助けをしよう", "インポスターの手助けをする" ,RoleId.Madmate);
        public static RoleInfo swapper = new RoleInfo("スワッパー", Swapper.color, "<color=#FF1919FF>人外</color> を追放するために票を交換しよう", "投票を入れ替える", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("シーア", Seer.color, "誰かが死んだのを見た...", "クルーが死ぬのを見る", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("ハッカー", Hacker.color, "<color=#FF1919FF>人外</color> を見つけるためにシステムをハックする", "ハックしてインポスターを見つけよう", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("トラッカー", Tracker.color, "人外を追い詰めよう", "人外を追い詰める", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("スニッチ", Snitch.color, "<color=#FF1919FF>インポスター</color>を見つけるためにタスクを終わらせよう", "タスクを終わらせる", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("ジャッカル", Jackal.color, "すべてのクルーと<color=#FF1919FF>インポスターを</color> ぶち殺そう", "みんなをぶち殺そう", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("サイドキック", Sidekick.color, "ジャッカルと一緒に船を壊そう", "ジャッカルのキルを手伝おう", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("スパイ", Spy.color, "<color=#FF1919FF>インポスター</color>を混乱させろ", "インポスターを混乱させる", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("警備員", SecurityGuard.color, "ベント塞いでカメラを設置しよう", "ベントを塞いでカメラを設置する", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("アーソニスト", Arsonist.color, "すべてを燃やして灰にしまおう", "船ごと燃やしてしまおう", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("ナイスゲッサー", Guesser.color, "あいつの役職は...", "あいつの役職を当てよう", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("イビルゲッサー", Palette.ImpostorRed, "あいつの役職は...", "あいつの役職を当てよう", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("ヴァルチャー", Vulture.color, "死体を食べよう", "死体を食べる", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("霊能者", Medium.color, "魂を訪ねて情報を得よう", "魂から情報を得る", RoleId.Medium);
        public static RoleInfo trapper = new RoleInfo("トラッパー", Trapper.color, "トラップを仕掛けてインポスターを見つけよう", "トラップを設置する", RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo("弁護士", Lawyer.color, "クライアントを守る", "クライアントを守る", RoleId.Lawyer, true);
        public static RoleInfo prosecutor = new RoleInfo("検察官", Lawyer.color, "ターゲットに投票しよう", "ターゲットに投票しよう", RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo("追跡者", Pursuer.color, "インポスターを排除せよ", "インポスターを排除する", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("インポスター", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "サボタージュとキルをする"), "サボタージュとキルをする", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("クルーメイト", Color.white, "インポスターを探しながら\nタスクを終えよう", "インポスターを探して\nタスクを終わらせる", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("ウィッチ", Witch.color, "クルーに魔法をかけよう", "クルーに魔法をかける", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("ニンジャ", Ninja.color, "クルーを驚かせてキルをしよう", "クルーを驚かせてキルをする", RoleId.Ninja);
        public static RoleInfo thief = new RoleInfo("シーフ", Thief.color, "キラーを1人キルして役職を奪おう", "キラーの役職を奪う", RoleId.Thief, true);
        public static RoleInfo bomber = new RoleInfo("ボンバー", Bomber.color, "船を爆発させよう!!", "爆発させる", RoleId.Bomber);

        public static RoleInfo hunter = new RoleInfo("鬼", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "みーつけた!^-^"), "クルーを探し、キルをする", RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo("ハンデット", Color.white, "隠そう", "隠す", RoleId.Crewmate);

        public static RoleInfo prop = new RoleInfo("プロップ", Color.white, "私はただのオブジェクト...", "モノに変装する", RoleId.Crewmate);


       //public static RoleInfo madmate = new RoleInfo("マッドメイト", Madmate.color, "インポスターの手助けをしよう", "インポスターの手助けをする", RoleId.Madmate);


        // Modifier
        public static RoleInfo bloody = new RoleInfo("血まみれ", Color.yellow, "キラーは血の跡を残す", "キラーは血の跡を残す", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("アンチテレポーター", Color.yellow, "テレポートされることはない", "テレポートされることはない", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("タイブレーカー", Color.yellow, "あなたの一票が同点に追いつく...", "同点に追いつく", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("ベイト", Color.yellow, "敵をおびき寄せる", "敵をおびき寄せる", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("サングラス", Color.yellow, "あなたはサングラスを手に入れた", "ビジョンが低下する", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("恋人", Lovers.color, $"あなたは恋をしている", $"あなたは恋をしている", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("ミニ", Color.yellow, "大人になるまで、誰もあなたを傷つけない", "誰もあなたを傷つけない", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "あなた様はVIPです!!", "あなた様が死んでしまうと\nと全員に通知がいきます", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("反転", Color.yellow, "動きが逆に...!", "動きが逆になってしまった!!", RoleId.Invert, false, true);
        public static RoleInfo chameleon = new RoleInfo("カメレオン", Color.yellow, "動いていないと見えにくい", "動いていないと見えにくい", RoleId.Chameleon, false, true);
        public static RoleInfo shifter = new RoleInfo("シフター", Color.yellow, "役職をシフトする", "役職をシフトする", RoleId.Shifter, false, true);

        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            //homeguard,
            madmate,
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            bomber,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            thief,
            prosecutor,
            crewmate,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            trapper,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert,
            chameleon,
            shifter
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead || AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Ended)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
                if (Chameleon.chameleon.Any(x => x.PlayerId == p.PlayerId)) infos.Add(chameleon);
                if (p == Shifter.shifter) infos.Add(shifter);
            }

            int count = infos.Count;  // Save count after modifiers are added so that the role count can be checked

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Madmate.madmate) infos.Add(madmate);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Bomber.bomber) infos.Add(bomber);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            //if (p == Homeguard.homeguard) infos.Add(homeguard);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer && !Lawyer.isProsecutor) infos.Add(lawyer);
            if (p == Lawyer.lawyer && Lawyer.isProsecutor) infos.Add(prosecutor);
            if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Pursuer.pursuer) infos.Add(pursuer);
            if (p == Thief.thief) infos.Add(thief);

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek, prop hunt prop ...
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek || TORMapOptions.gameMode == CustomGamemodes.PropHunt ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : TORMapOptions.gameMode == CustomGamemodes.PropHunt ? RoleInfo.prop : RoleInfo.crewmate);
            }

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true, bool suppressGhostInfo = false) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) 
                roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId)) roleName += " (Guesser)";

            if (!suppressGhostInfo && p != null) {
                if (p == Shifter.shifter && (CachedPlayer.LocalPlayer.PlayerControl == Shifter.shifter || Helpers.shouldShowGhostInfo()) && Shifter.futureShift != null)
                    roleName += Helpers.cs(Color.yellow, " ← " + Shifter.futureShift.Data.PlayerName);
                if (p == Vulture.vulture && (CachedPlayer.LocalPlayer.PlayerControl == Vulture.vulture || Helpers.shouldShowGhostInfo()))
                    roleName = roleName + Helpers.cs(Vulture.color, $" ({Vulture.vultureNumberToWin - Vulture.eatenBodies} left)");
                if (Helpers.shouldShowGhostInfo()) {
                    if (Eraser.futureErased.Contains(p))
                        roleName = Helpers.cs(Color.gray, "(erased) ") + roleName;
                    if (Vampire.vampire != null && !Vampire.vampire.Data.IsDead && Vampire.bitten == p && !p.Data.IsDead)
                        roleName = Helpers.cs(Vampire.color, $"(bitten {(int)HudManagerStartPatch.vampireKillButton.Timer + 1}) ") + roleName;
                    if (Deputy.handcuffedPlayers.Contains(p.PlayerId))
                        roleName = Helpers.cs(Color.gray, "(cuffed) ") + roleName;
                    if (Deputy.handcuffedKnows.ContainsKey(p.PlayerId))  // Active cuff
                        roleName = Helpers.cs(Deputy.color, "(cuffed) ") + roleName;
                    if (p == Warlock.curseVictim)
                        roleName = Helpers.cs(Warlock.color, "(cursed) ") + roleName;
                    if (p == Ninja.ninjaMarked)
                        roleName = Helpers.cs(Ninja.color, "(marked) ") + roleName;
                    if (Pursuer.blankedList.Contains(p) && !p.Data.IsDead)
                        roleName = Helpers.cs(Pursuer.color, "(blanked) ") + roleName;
                    if (Witch.futureSpelled.Contains(p) && !MeetingHud.Instance) // This is already displayed in meetings!
                        roleName = Helpers.cs(Witch.color, "☆ ") + roleName;
                    if (BountyHunter.bounty == p)
                        roleName = Helpers.cs(BountyHunter.color, "(bounty) ") + roleName;
                    if (Arsonist.dousedPlayers.Contains(p))
                        roleName = Helpers.cs(Arsonist.color, "♨ ") + roleName;
                    if (p == Arsonist.arsonist)
                        roleName = roleName + Helpers.cs(Arsonist.color, $" ({CachedPlayer.AllPlayers.Count(x => { return x.PlayerControl != Arsonist.arsonist && !x.Data.IsDead && !x.Data.Disconnected && !Arsonist.dousedPlayers.Any(y => y.PlayerId == x.PlayerId); })} left)");
                    if (p == Jackal.fakeSidekick)
                        roleName = Helpers.cs(Sidekick.color, $" (fake SK)") + roleName;

                    // Death Reason on Ghosts
                    if (p.Data.IsDead) {
                        string deathReasonString = "";
                        var deadPlayer = GameHistory.deadPlayers.FirstOrDefault(x => x.player.PlayerId == p.PlayerId);

                        Color killerColor = new();
                        if (deadPlayer != null && deadPlayer.killerIfExisting != null) {
                            killerColor = RoleInfo.getRoleInfoForPlayer(deadPlayer.killerIfExisting, false).FirstOrDefault().color;
                        }

                        if (deadPlayer != null) {
                            switch (deadPlayer.deathReason) {
                                case DeadPlayer.CustomDeathReason.Disconnect:
                                    deathReasonString = " - disconnected";
                                    break;
                                case DeadPlayer.CustomDeathReason.Exile:
                                    deathReasonString = " - voted out";
                                    break;
                                case DeadPlayer.CustomDeathReason.Kill:
                                    deathReasonString = $" - killed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Guess:
                                    if (deadPlayer.killerIfExisting.Data.PlayerName == p.Data.PlayerName)
                                        deathReasonString = $" - failed guess";
                                    else
                                        deathReasonString = $" - guessed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Shift:
                                    deathReasonString = $" - {Helpers.cs(Color.yellow, "shifted")} {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.WitchExile:
                                    deathReasonString = $" - {Helpers.cs(Witch.color, "witched")} by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LoverSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lovers.color, "lover died")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LawyerSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lawyer.color, "bad Lawyer")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Bomb:
                                    deathReasonString = $" - bombed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Arson:
                                    deathReasonString = $" - burnt by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                            }
                            roleName = roleName + deathReasonString;
                        }
                    }
                }
            }
            return roleName;
        }


        static string ReadmePage = "";
        public static async Task loadReadme() {
            if (ReadmePage == "") {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/TheOtherRolesAU/TheOtherRoles/main/README.md");
                response.EnsureSuccessStatusCode();
                string httpres = await response.Content.ReadAsStringAsync();
                ReadmePage = httpres;
            }
        }
        public static string GetRoleDescription(RoleInfo roleInfo) {
            while (ReadmePage == "") {
            }
                
            int index = ReadmePage.IndexOf($"## {roleInfo.name}");
            int endindex = ReadmePage.Substring(index).IndexOf("### Game Options");
            return ReadmePage.Substring(index, endindex);

        }
    }
}
