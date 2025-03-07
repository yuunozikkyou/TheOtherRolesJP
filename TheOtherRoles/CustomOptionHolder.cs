using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
        public static string[] presets = new string[]{"Preset 1", "Preset 2", "Random Preset Skeld", "Random Preset Mira HQ", "Random Preset Polus", "Random Preset Airship", "Random Preset Submerged" };

        public static CustomOption madmateCanMoveInVent;
        public static CustomOption madmateSpawnRate;
public static CustomOption madmateCanEnterVents;
public static CustomOption madmateHasImpostorVision;
public static CustomOption madmateExileCrewmate;
public static CustomOption madmateCanDieToSheriff;
        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption crewmateRolesFill;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption anyPlayerCanStopStart;
        public static CustomOption enableEventMode;
        public static CustomOption deadImpsBlockSabotage;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterHasImpostorVision;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanSabotageLights;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption sidekickCanSabotageLights;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;
        public static CustomOption mayorChooseSingleVote;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;
        public static CustomOption portalmakerCanPortalFromAnywhere;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterFlashlightWidth;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;
        public static CustomOption trackerTrackingMethod;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchMode;
        public static CustomOption snitchTargets;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;
        public static CustomOption mediumChanceAdditionalInfo;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerIsProsecutorChance;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption lawyerCanCallEmergency;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption thiefSpawnRate;
        public static CustomOption thiefCooldown;
        public static CustomOption thiefHasImpVision;
        public static CustomOption thiefCanUseVents;
        public static CustomOption thiefCanKillSheriff;
        public static CustomOption thiefCanStealWithGuess;


        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombDestructionTime;
        public static CustomOption bomberBombDestructionRange;
        public static CustomOption bomberBombHearRange;
        public static CustomOption bomberDefuseDuration;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberBombActiveAfter;

        public static CustomOption yoyoSpawnRate;
        public static CustomOption yoyoBlinkDuration;
        public static CustomOption yoyoMarkCooldown;
        public static CustomOption yoyoMarkStaysOverMeeting;
        public static CustomOption yoyoHasAdminTable;
        public static CustomOption yoyoAdminTableCooldown;
        public static CustomOption yoyoSilhouetteVisibility;



        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;
        public static CustomOption modifierMiniGrowingUpInMeeting;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;

        public static CustomOption modifierChameleon;
        public static CustomOption modifierChameleonQuantity;
        public static CustomOption modifierChameleonHoldDuration;
        public static CustomOption modifierChameleonFadeDuration;
        public static CustomOption modifierChameleonMinVisibility;

        public static CustomOption modifierShifter;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;
        public static CustomOption finishTasksBeforeHauntingOrZoomingOut;
        public static CustomOption camsNightVision;
        public static CustomOption camsNoNightVisionIfImpVision;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableFungle;
        public static CustomOption dynamicMapEnableSubmerged;
        public static CustomOption dynamicMapSeparateSettings;

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserForceThiefGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;
        public static CustomOption guesserGamemodeSidekickIsAlwaysGuesser;

        // Hide N Seek Gamemode
        public static CustomOption hideNSeekHunterCount;
        public static CustomOption hideNSeekKillCooldown;
        public static CustomOption hideNSeekHunterVision;
        public static CustomOption hideNSeekHuntedVision;
        public static CustomOption hideNSeekTimer;
        public static CustomOption hideNSeekCommonTasks;
        public static CustomOption hideNSeekShortTasks;
        public static CustomOption hideNSeekLongTasks;
        public static CustomOption hideNSeekTaskWin;
        public static CustomOption hideNSeekTaskPunish;
        public static CustomOption hideNSeekCanSabotage;
        public static CustomOption hideNSeekMap;
        public static CustomOption hideNSeekHunterWaiting;

        public static CustomOption hunterLightCooldown;
        public static CustomOption hunterLightDuration;
        public static CustomOption hunterLightVision;
        public static CustomOption hunterLightPunish;
        public static CustomOption hunterAdminCooldown;
        public static CustomOption hunterAdminDuration;
        public static CustomOption hunterAdminPunish;
        public static CustomOption hunterArrowCooldown;
        public static CustomOption hunterArrowDuration;
        public static CustomOption hunterArrowPunish;

        public static CustomOption huntedShieldCooldown;
        public static CustomOption huntedShieldDuration;
        public static CustomOption huntedShieldRewindTime;
        public static CustomOption huntedShieldNumber;

        // Prop Hunt Settings
        public static CustomOption propHuntMap;
        public static CustomOption propHuntTimer;
        public static CustomOption propHuntNumberOfHunters;
        public static CustomOption hunterInitialBlackoutTime;
        public static CustomOption hunterMissCooldown;
        public static CustomOption hunterHitCooldown;
        public static CustomOption hunterMaxMissesBeforeDeath;
        public static CustomOption propBecomesHunterWhenFound;
        public static CustomOption propHunterVision;
        public static CustomOption propVision;
        public static CustomOption propHuntRevealCooldown;
        public static CustomOption propHuntRevealDuration;
        public static CustomOption propHuntRevealPunish;
        public static CustomOption propHuntUnstuckCooldown;
        public static CustomOption propHuntUnstuckDuration;
        public static CustomOption propHuntInvisCooldown;
        public static CustomOption propHuntInvisDuration;
        public static CustomOption propHuntSpeedboostCooldown;
        public static CustomOption propHuntSpeedboostDuration;
        public static CustomOption propHuntSpeedboostSpeed;
        public static CustomOption propHuntSpeedboostEnabled;
        public static CustomOption propHuntInvisEnabled;
        public static CustomOption propHuntAdminCooldown;
        public static CustomOption propHuntFindCooldown;
        public static CustomOption propHuntFindDuration;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static bool isMapSelectionOption(CustomOption option) {
            return option == CustomOptionHolder.propHuntMap && option == CustomOptionHolder.hideNSeekMap;
        }

        public static void Load() {
            CustomOption.vanillaSettings = TheOtherRolesPlugin.Instance.Config.Bind("プリセット0", "バニラオプション", "");

            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "プリセット"), presets, null, true);

            
            if (Utilities.EventUtility.canBeEnabled) enableEventMode = CustomOption.Create(10423, Types.General, cs(Color.green, "スペシャルモードを有効にする"), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小クルー役職数"), 15f, 0f, 15f, 1f, null, true, heading: "Min/Max Roles");
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大クルー役職数"), 15f, 0f, 15f, 1f);            
            neutralRolesCountMin = CustomOption.Create(302, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小第三陣営数"), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大大歳陣営数"), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小インポスター役職数"), 15f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大インポスター役職数"), 15f, 0f, 15f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大属性数"), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Maximum Modifiers"), 15f, 0f, 15f, 1f);
            crewmateRolesFill = CustomOption.Create(308, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "クルーの役職をうめる\n(最小/最大関係なし"), false);

            mafiaSpawnRate = CustomOption.Create(18, Types.Impostor, cs(Janitor.color, "マフィア"), rates, null, true);
            janitorCooldown = CustomOption.Create(19, Types.Impostor, "ジャニターのクールダウン", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, cs(Morphling.color, "モーフィング"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, "モーフリングのクールダウン", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, "モーフの持続時間", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, cs(Camouflager.color, "カモフラージャー"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, "カモフラージュのクールダウン", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, "カモフラージュの持続時間", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, cs(Vampire.color, "ヴァンパイア"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, "ヴァンパイアキルの遅延", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, "ヴァンパイアのクールダウン", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43, Types.Impostor, "ニンニクの近くでキルすることができる", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, cs(Eraser.color, "イレイサー"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, "イレイサーのクールダウン", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, "イレイサーはどの役職でも消せる", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, cs(Trickster.color, "トリックスター"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, "トリックスターボックスのクールダウン", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, "ライトアウトクールダウン", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, "ライトアウト持続時間", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, cs(Cleaner.color, "クリーナー"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, "クリーナークールダウン", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, cs(Cleaner.color, "魔術師"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, "魔術師のクールダウン", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, "魔術師のルートタイム", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, cs(BountyHunter.color, "バウンティーハンター"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, "ターゲットが変更される時間",  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, "ターゲットをキルした時のクールダウン", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, "ターゲット以外をキルした時のクールダウン", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, "ターゲットに矢印を向ける", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, "矢印の更新間隔", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, cs(Witch.color, "ウィッチ"), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, "ウィッチの呪文のクールダウン", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, "ウィッチの追加のクールダウン", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, "ウィッチは誰にでも呪文をかけられる", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, "呪文の持続時間", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, "両方のクールダウンを同期", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, "ウィッチの投票がすべてのターゲットを救う", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "ニンジャ"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "忍者マークのクールダウン", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "ニンジャはターゲットの位置を知れる", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "トレース時間", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "トレースの色が消えるまでの時間", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "ニンジャの透明時間", 3f, 0f, 20f, 1f, ninjaSpawnRate);

            bomberSpawnRate = CustomOption.Create(460, Types.Impostor, cs(Bomber.color, "ボンバー"), rates, null, true);
            bomberBombDestructionTime = CustomOption.Create(461, Types.Impostor, "爆弾の破壊時間", 20f, 2.5f, 120f, 2.5f, bomberSpawnRate);
            bomberBombDestructionRange = CustomOption.Create(462, Types.Impostor, "爆弾の破壊範囲", 50f, 5f, 150f, 5f, bomberSpawnRate);
            bomberBombHearRange = CustomOption.Create(463, Types.Impostor, "爆弾のレンジ", 60f, 5f, 150f, 5f, bomberSpawnRate);
            bomberDefuseDuration = CustomOption.Create(464, Types.Impostor, "爆弾の信管解除時間", 3f, 0.5f, 30f, 0.5f, bomberSpawnRate);
            bomberBombCooldown = CustomOption.Create(465, Types.Impostor, "爆弾のクールダウン", 15f, 2.5f, 30f, 2.5f, bomberSpawnRate);
            bomberBombActiveAfter = CustomOption.Create(466, Types.Impostor, "爆弾が作動する時間", 3f, 0.5f, 15f, 0.5f, bomberSpawnRate);

            yoyoSpawnRate = CustomOption.Create(470, Types.Impostor, cs(Yoyo.color, "ヨーヨー"), rates, null, true);
            yoyoBlinkDuration = CustomOption.Create(471, Types.Impostor, "ブリンク時間", 20f, 2.5f, 120f, 2.5f, yoyoSpawnRate);
            yoyoMarkCooldown = CustomOption.Create(472, Types.Impostor, "マーク位置のクールダウン", 20f, 2.5f, 120f, 2.5f, yoyoSpawnRate);
            yoyoMarkStaysOverMeeting = CustomOption.Create(473, Types.Impostor, "マークされた場所はミーティング後も残る", true, yoyoSpawnRate);
            yoyoHasAdminTable = CustomOption.Create(474, Types.Impostor, "アドミンテーブル", true, yoyoSpawnRate);
            yoyoAdminTableCooldown = CustomOption.Create(475, Types.Impostor, "アドミンテーブルのクールダウン", 20f, 2.5f, 120f, 2.5f, yoyoHasAdminTable);
            yoyoSilhouetteVisibility = CustomOption.Create(476, Types.Impostor, "シルエットの視認性", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, yoyoSpawnRate);


            guesserSpawnRate = CustomOption.Create(310, Types.Neutral, cs(Guesser.color, "ゲッサー"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, Types.Neutral, "ゲッサーがインポスターの可能性", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, Types.Neutral, "ゲッサーが撃てる数", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Neutral, "ゲーザーは1回のミーティングにつき複数回の推測が可能", false, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315, Types.Neutral, "メディックシールドを無視した推測", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316, Types.Neutral, "ゲッサーは、スパイを推測できる", true, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, Types.Neutral, "ゲッサーのスポーン確率", rates, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Neutral, "ゲッサーはタスク完了時にスニッチを推理できない", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, cs(Jester.color, "ジェスター"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, "ジェスターは緊急会議できる", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, "インポスタービジョン", false, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, cs(Arsonist.color, "アーソニスト"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, "アーソニストのクールダウン", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, "アーソニストの塗る時間", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, cs(Jackal.color, "ジャッカル"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, "Jジャッカルとサイドキックキルクールダウン", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, "サイドキックのクールダウン", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, "ジャッカルがベントを使用できる", true, jackalSpawnRate);
            jackalCanSabotageLights = CustomOption.Create(431, Types.Neutral, "ジャッカルが停電を起こせるか", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, "ジャッカルがサイドキックを作れる", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, "ジャッカル死亡時、サイドキックがジャッカルに昇格する", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, "サイドキックは殺せる", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, "サイドキックはベントを使用できる", true, jackalCanCreateSidekick);
            sidekickCanSabotageLights = CustomOption.Create(432, Types.Neutral, "サイドキックが停電を起こせるか", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, "サイドキックから昇格したジャッカルはサイドキックを作れる", true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, "ジャッカルはインポスターをサイドキックにできる", true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, "ジャッカルとサイドキックはインポスタービジョンを持つ", false, jackalSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, cs(Vulture.color, "ヴァルチャー"), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, "ヴァルチャークールダウン", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, "食べなければならない死体の数", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, "ヴァルチャーがベントを使える", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, "死体の方向に矢印を向ける", true, vultureSpawnRate);

            madmateSpawnRate = CustomOption.Create(910, Types.Crewmate, cs(Madmate.color, "マッドメイト"), rates, null, true);
            madmateExileCrewmate = CustomOption.Create(918, Types.Crewmate, "エグザイルクルーメイト", false, madmateSpawnRate);
            madmateCanDieToSheriff = CustomOption.Create(911, Types.Crewmate, "シェリフがマッドメイトを切れるか", true, madmateSpawnRate);
            madmateCanEnterVents = CustomOption.Create(912, Types.Crewmate, "ベントに入れるか", true, madmateSpawnRate);
            madmateCanMoveInVent = CustomOption.Create(913, Types.Crewmate, "ベント移動ができるか", true, madmateCanEnterVents);
            madmateHasImpostorVision = CustomOption.Create(913, Types.Crewmate, "インポスタービジョンか", false, madmateSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, cs(Lawyer.color, "弁護士"), rates, null, true);
            lawyerIsProsecutorChance = CustomOption.Create(358, Types.Neutral, "弁護士が検察官である可能性", rates, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, Types.Neutral, "ビジョン", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, "弁護士/検事はターゲットの役割を知っているe", false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, Types.Neutral, "弁護士/検事は緊急会議を招集できるg", true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, "弁護士がジェスターになる", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, "ブランクのクールダウン時間", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, "追跡者ブランク数", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, cs(Mayor.color, "メイヤー"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, "メイヤーはどこに投票したか見える", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "どこに投票したかを見るために必要な完了したタスク", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "モバイル緊急ボタン", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "遠隔会議の回数", 1f, 1f, 5f, 1f, mayorMeetingButton);
            mayorChooseSingleVote = CustomOption.Create(85, Types.Crewmate, "メイヤーは単一投票を選択できる", new string[] { "Off", "On (Before Voting)", "On (Until Meeting Ends)" }, mayorSpawnRate);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, cs(Engineer.color, "エンジニア"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, "サボタージュの直せる数", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, "インポスターはベントが強調されるのを見る", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, "ジャッカルとサイドキックがベントを強調", true, engineerSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, cs(Sheriff.color, "シェリフ"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, "シェリフのクールダウン", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, "シェリフが第三陣営をキルできる", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, "シェリフには代理人がいる", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, "手錠の数", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, "手錠のクールダウン", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, "手錠の持続時間", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, "シェリフと代理人は互いに視認できる", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, "代理人がシェリフに昇格できる", new string[] { "Off", "On (Immediately)", "On (After Meeting)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, "昇進したシェリフが手錠を保持してるか", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, cs(Lighter.color, "ライター"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, "停電ではない時の視界の広がり具合", 1.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, "停電のときの視界の広がり具合", 0.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterFlashlightWidth = CustomOption.Create(113, Types.Crewmate, "懐中電灯の幅", 0.3f, 0.1f, 1f, 0.1f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, cs(Detective.color, "探偵"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, "匿名の足跡", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, "フットプリント間隔", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, "フットプリント持続時間", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, "探偵レポートが名前を持つようになる時間", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, "探偵レポートがカラータイプになる時間", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, cs(TimeMaster.color, "タイムマスター"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, "タイムマスターのクールダウン", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, "巻き戻される時間", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, "タイムマスターシールド持続時間", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, cs(Medic.color, "メディック"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, "シールドを貼ったプレイヤーを表示する", new string[] {"全員", "シールド+メディック", "メディック"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, "シールドが貼られたプレイヤーが殺害未遂を見る", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, "シールド発動", new string[] { "即座に", "即座に, ミーティング後\nに見える", "ミーティング後" }, medicSpawnRate);

            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, "メディックが遮蔽されたプレイヤーへの殺人未遂を目撃", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, cs(Swapper.color, "スワッパー"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, "スワッパーが緊急会議を招集できる", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, "スワッパーは他人としかスワップできない", false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "スワップ初期回数", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "復活に必要なタスク数", 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, cs(Seer.color, "シーア"), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, "シアーモード", new string[]{ "キルフラッシュ+ソウルを見せる", "キルフラッシュ", "魂を見せる"}, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, "魂の持続時間を制御", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, "シアーソウル持続時間", 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, cs(Hacker.color, "ハッカー"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, "ハッカーのクールダウン", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, "ハッカーの時間", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, "ハッカーはカラータイプしか見ない", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, "モバイルガジェットの最大充電", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, "充電に必要なタスク数", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, "モバイルガジェットの使用時間中に移動できない", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, cs(Tracker.color, "トラッカー"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, "トラッカー更新間隔", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, "トラッカー、ミーティング後に目標をリセット", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, "トラッカーは死体を追跡できる", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, "死体追跡クールダウン", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, "死体の追跡期間", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
            trackerTrackingMethod = CustomOption.Create(206, Types.Crewmate, "トラッカーが目標位置を取得する方法", new string[] { "アローのみ", "プロキシミティのみ", "アロー＋プロキシミティ" }, trackerSpawnRate);
                           
            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, cs(Snitch.color, "スニッチ"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(219, Types.Crewmate, "スニッチが現れるタスクカウント", 5f, 0f, 25f, 1f, snitchSpawnRate);
            snitchMode = CustomOption.Create(211, Types.Crewmate, "情報モード", new string[] { "チャット", "マップ", "チャット と マップ" }, snitchSpawnRate);
            snitchTargets = CustomOption.Create(212, Types.Crewmate, "ターゲット", new string[] { "すべての悪の選手", "プレイヤーを殺す" }, snitchSpawnRate);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, cs(Spy.color, "スパイ"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, "スパイはシェリフと死ねる", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, "スパイがいればインポスターは誰でも殺せる", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, "スパイはベントに入れる", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, "スパイはインポスタービジョンを持つ", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "ポータルメーカー"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "ポータルメーカーのクールダウン", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "ポータルのクールダウン", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "ポータルメーカーログのみカラータイプを表示", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "ログは時間を示す", true, portalmakerSpawnRate);
            portalmakerCanPortalFromAnywhere = CustomOption.Create(395, Types.Crewmate, "どこからでもポータルにアクセスできる", true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, cs(SecurityGuard.color, "警備員"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, "警備員のクールダウン", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, "警備員 ネジ数", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, "カメラあたりのネジ数", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, "ベント1個あたりのネジ数", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, "カメラ、センサー持続時間", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, "最大チャージ数", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, "充電に必要なタスク数", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, "カメラ使用中は移動できない", true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, cs(Medium.color, "霊能者"), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, "ミディアムクエスチョンクールダウン", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, "質問時間", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, "それぞれの魂は一度しか問われない", false, mediumSpawnRate);
            mediumChanceAdditionalInfo = CustomOption.Create(364, Types.Crewmate, "答えに追加情報が\n含まれている可能性", rates, mediumSpawnRate);

            thiefSpawnRate = CustomOption.Create(400, Types.Neutral, cs(Thief.color, "シーフ(泥棒)"), rates, null, true);
            thiefCooldown = CustomOption.Create(401, Types.Neutral, "シーフクールダウン", 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, Types.Neutral, "シーフはシェリフを殺せる", true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, Types.Neutral, "インポスタービジョン", true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, Types.Neutral, "シーフがベントに入れる", true, thiefSpawnRate);
            thiefCanStealWithGuess = CustomOption.Create(405, Types.Neutral, "シーフは役を推測して盗むことができる（推測した場合）", false, thiefSpawnRate);

            trapperSpawnRate = CustomOption.Create(410, Types.Crewmate, cs(Trapper.color, "トラッパー"), rates, null, true);
            trapperCooldown = CustomOption.Create(420, Types.Crewmate, "トラッパーのクールダウン", 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, Types.Crewmate, "最大トラップ数", 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, Types.Crewmate, "充電に必要なタスク数", 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, Types.Crewmate, "トラップはトリガーを必要とする", 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, Types.Crewmate, "匿名マップを表示", false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, Types.Crewmate, "トラップ情報タイプ", new string[] { "役職", "善/悪", "名前" }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, Types.Crewmate, "トラップ持続時間", 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1009, Types.Modifier, cs(Color.yellow, "死亡後効果のModifierを隠す"), true, null, true);

            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "血まみれ"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "血まみれの量"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "トレイル時間", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "アンチテレポート"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "アンチテレポート数量"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "タイブレーカー"), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "ベイト"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "ベイト量"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "ベイトレポート遅延分", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "ベイトレポート遅延最大", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "フラッシュで犯人に警告", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "恋人"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "恋人がインポスターである可能性", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "両思いは死ぬ", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "恋人チャットを有効にする", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "サングラス"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "サングラス数量"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "サングラスをかけたビジョン", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "ミニ"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "ミニの成長時間", 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, Types.Modifier, "ミニがミーティングで成長するか", true, modifierMini);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "VIP"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "VIP数量"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "チームカラーを表示", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "反転"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "Modifier 数量"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "ミーティング数 反転", 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, Types.Modifier, cs(Color.yellow, "カメレオン"), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, Types.Modifier, cs(Color.yellow, "カメレオンのコピー数量"), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, Types.Modifier, "透過するまでの時間", 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, Types.Modifier, "フェード時間", 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, Types.Modifier, "最低視認性", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, Types.Modifier, cs(Color.yellow, "シフター"), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, Types.Guesser, cs(Guesser.color, "ゲッサーが推測できる回数"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, Types.Guesser, cs(Guesser.color, "ニュートラルゲッサーが推測できる回数"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeImpNumber = CustomOption.Create(2003, Types.Guesser, cs(Guesser.color, "イビルゲッサーの数"), 15f, 1f, 15f, 1f, null, true);
            guesserForceJackalGuesser = CustomOption.Create(2007, Types.Guesser, "ジャッカルゲッサー", false, null, true);
            guesserGamemodeSidekickIsAlwaysGuesser = CustomOption.Create(2012, Types.Guesser, "サイドキックゲッサー", false, null);
            guesserForceThiefGuesser = CustomOption.Create(2011, Types.Guesser, "シーフゲッサー", false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, Types.Guesser, "ゲッサーは属性を持つことができる", true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, Types.Guesser, "推測できる数", 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, Types.Guesser, "ゲッサーは1回のミーティングにつき複数推測できる", false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, Types.Guesser, "メディックシールドを無視した推測", true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, Types.Guesser, "イビルゲッサーはスパイを推測できる", true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, Types.Guesser, "ゲッサーはタスク完了時にスニッチを推測できない", true, null);
            // Care: 2012 already taken!
            

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, Types.HideNSeekMain, cs(Color.yellow, "マップ"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Fungle", "Submerged", "LI Map"}, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            hideNSeekHunterCount = CustomOption.Create(3000, Types.HideNSeekMain, cs(Color.yellow, "鬼の数"), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, Types.HideNSeekMain, cs(Color.yellow, "キルクールダウン"), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, Types.HideNSeekMain, cs(Color.yellow, "ハンタービジョン"), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, Types.HideNSeekMain, cs(Color.yellow, "ハンティングビジョン"), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, Types.HideNSeekMain, cs(Color.yellow, "通常タスク"), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, Types.HideNSeekMain, cs(Color.yellow, "ショートタスク"), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, Types.HideNSeekMain, cs(Color.yellow, "ロングタスク"), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, Types.HideNSeekMain, cs(Color.yellow, "時間 分"), 5f, 1f, 30f, 0.5f);
            hideNSeekTaskWin = CustomOption.Create(3004, Types.HideNSeekMain, cs(Color.yellow, "タスク勝利が可能"), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, Types.HideNSeekMain, cs(Color.yellow, "タスクを終わらせる 秒単位で罰する"), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, Types.HideNSeekMain, cs(Color.yellow, "サボタージュを可能にする"), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, Types.HideNSeekMain, cs(Color.yellow, "鬼に必要な時間"), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, Types.HideNSeekRoles, cs(Color.red, "鬼のライトのクールダウン"), 30f, 5f, 60f, 1f, null, true);
            hunterLightDuration = CustomOption.Create(3006, Types.HideNSeekRoles, cs(Color.red, "鬼のライト点灯時間"), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, Types.HideNSeekRoles, cs(Color.red, "鬼のライトビジョン"), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, Types.HideNSeekRoles, cs(Color.red, "鬼のライト"), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, Types.HideNSeekRoles, cs(Color.red, "鬼のアドミンクールダウン"), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, Types.HideNSeekRoles, cs(Color.red, "鬼のアドミン期間"), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, Types.HideNSeekRoles, cs(Color.red, "鬼の管理者が秒単位で処罰"), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, Types.HideNSeekRoles, cs(Color.red, "鬼のアローのクールダウン"), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, Types.HideNSeekRoles, cs(Color.red, "鬼のアロー持続時間"), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, Types.HideNSeekRoles, cs(Color.red, "鬼のアロー"), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, Types.HideNSeekRoles, cs(Color.gray, "ハンティング・シールドのクールダウン"), 30f, 5f, 60f, 1f, null, true);
            huntedShieldDuration = CustomOption.Create(3016, Types.HideNSeekRoles, cs(Color.gray, "ハンテッド・シールド"), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, Types.HideNSeekRoles, cs(Color.gray, "ハンテッド・リワインド・タイム"), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, Types.HideNSeekRoles, cs(Color.gray, "ハンティングシールド番号"), 3f, 1f, 15f, 1f);

            // Prop Hunt General Options
            propHuntMap = CustomOption.Create(4020, Types.PropHunt, cs(Color.yellow, "マップ"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Fungle", "Submerged", "LI Map"}, null, true, onChange: ()=> { int map = propHuntMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map;});
            propHuntTimer = CustomOption.Create(4021, Types.PropHunt, cs(Color.yellow, "時間 分"), 5f, 1f, 30f, 0.5f);
            propHuntUnstuckCooldown = CustomOption.Create(4011, Types.PropHunt, cs(Color.yellow, "アンスタック・クールダウン"), 30f, 2.5f, 60f, 2.5f);
            propHuntUnstuckDuration = CustomOption.Create(4012, Types.PropHunt, cs(Color.yellow, "停滞しない期間"), 2f, 1f, 60f, 1f);
            propHunterVision = CustomOption.Create(4006, Types.PropHunt, cs(Color.yellow, "鬼のビジョン"), 0.5f, 0.25f, 2f, 0.25f);
            propVision = CustomOption.Create(4007, Types.PropHunt, cs(Color.yellow, "プロップ・ビジョン"), 2f, 0.25f, 5f, 0.25f);
            // Hunter Options
            propHuntNumberOfHunters = CustomOption.Create(4000, Types.PropHunt, cs(Color.red, "鬼の数"), 1f, 1f, 5f, 1f, null, true);
            hunterInitialBlackoutTime = CustomOption.Create(4001, Types.PropHunt, cs(Color.red, "ハンターの初期停電時間"), 10f, 5f, 20f, 1f);
            hunterMissCooldown = CustomOption.Create(4004, Types.PropHunt, cs(Color.red, "ミス後のキル・クールダウン"), 10f, 2.5f, 60f, 2.5f);
            hunterHitCooldown = CustomOption.Create(4005, Types.PropHunt, cs(Color.red, "ヒット後のキル・クールダウン"), 10f, 2.5f, 60f, 2.5f);
            propHuntRevealCooldown = CustomOption.Create(4008, Types.PropHunt, cs(Color.red, "プロップのクールダウン"), 30f, 10f, 90f, 2.5f);
            propHuntRevealDuration = CustomOption.Create(4009, Types.PropHunt, cs(Color.red, "プロップ期間"), 5f, 1f, 60f, 1f);
            propHuntRevealPunish = CustomOption.Create(4010, Types.PropHunt, cs(Color.red, "暴露タイム 罰"), 10f, 0f, 1800f, 5f);
            propHuntAdminCooldown = CustomOption.Create(4022, Types.PropHunt, cs(Color.red, "鬼のアドミンクールダウン"), 30f, 2.5f, 1800f, 2.5f);
            propHuntFindCooldown = CustomOption.Create(4023, Types.PropHunt, cs(Color.red, "クールダウンを探す"), 60f, 2.5f, 1800f, 2.5f);
            propHuntFindDuration = CustomOption.Create(4024, Types.PropHunt, cs(Color.red, "期間検索"), 5f, 1f, 15f, 1f);
            // Prop Options
            propBecomesHunterWhenFound = CustomOption.Create(4003, Types.PropHunt, cs(Palette.CrewmateBlue, "小道具が見つかるとハンターになる"), false, null, true);
            propHuntInvisEnabled = CustomOption.Create(4013, Types.PropHunt, cs(Palette.CrewmateBlue, "不可視有効"), true, null, true);
            propHuntInvisCooldown = CustomOption.Create(4014, Types.PropHunt, cs(Palette.CrewmateBlue, "不可視のクールダウン"), 120f, 10f, 1800f, 2.5f, propHuntInvisEnabled);
            propHuntInvisDuration = CustomOption.Create(4015, Types.PropHunt, cs(Palette.CrewmateBlue, "不可視時間"), 5f, 1f, 30f, 1f, propHuntInvisEnabled);
            propHuntSpeedboostEnabled = CustomOption.Create(4016, Types.PropHunt, cs(Palette.CrewmateBlue, "スピードブースト有効"), true, null, true);
            propHuntSpeedboostCooldown = CustomOption.Create(4017, Types.PropHunt, cs(Palette.CrewmateBlue, "スピードブーストのクールダウン"), 60f, 2.5f, 1800f, 2.5f, propHuntSpeedboostEnabled);
            propHuntSpeedboostDuration = CustomOption.Create(4018, Types.PropHunt, cs(Palette.CrewmateBlue, "スピードブースト持続時間"), 5f, 1f, 15f, 1f, propHuntSpeedboostEnabled);
            propHuntSpeedboostSpeed = CustomOption.Create(4019, Types.PropHunt, cs(Palette.CrewmateBlue, "スピードブースト比"), 2f, 1.25f, 5f, 0.25f, propHuntSpeedboostEnabled);



            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, "会議回数（メイヤー会議を除く）", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, "緊急会議でのブロック・スキップ", false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, "無投票は自己投票", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, "プレイヤー名を隠す", false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, "メドベイの並行スキャンを許可する", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "シールド 最終戦 ファーストキル", false);
            finishTasksBeforeHauntingOrZoomingOut = CustomOption.Create(9, Types.General, "ハウンティングやズームアウトする前にタスクを終わらせる", true);
            camsNightVision = CustomOption.Create(11, Types.General, "照明がオフの場合、カムはナイトビジョンに切り替わる", false, null, true);
            camsNoNightVisionIfImpVision = CustomOption.Create(12, Types.General, "ナイトビジョンカメラを無視するインポスター・ビジョン", false, camsNightVision, false);
            deadImpsBlockSabotage = CustomOption.Create(13, Types.General, cs(Palette.ImpostorRed, "死亡したインポスターがサボタージュを起こすのを無効化する"), false, null, false);


            dynamicMap = CustomOption.Create(500, Types.General, "ランダムマップで遊ぶ", false, null, true);
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, "Skeld", rates, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, "Mira", rates, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, "Polus", rates, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, "Airship", rates, dynamicMap, false);
            dynamicMapEnableFungle = CustomOption.Create(506, Types.General, "Fungle", rates, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "Submerged", rates, dynamicMap, false);
            dynamicMapSeparateSettings = CustomOption.Create(509, Types.General, "ランダムマップ設定プリセットを使用する", false, dynamicMap, false);


            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});
            
        }
    }
}
