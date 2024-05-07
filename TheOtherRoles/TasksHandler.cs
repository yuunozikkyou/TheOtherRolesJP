using HarmonyLib;
using System;
using TheOtherRoles.Patches;
using TheOtherRoles.Players;
using TheOtherRoles.Utilities;

namespace TheOtherRoles {
    [HarmonyPatch]
    public static class TasksHandler {
        public static Tuple<int, int> taskInfo(GameData.PlayerInfo playerInfo, bool madmateCount = false, bool isResult = false) {
            int TotalTasks = 0;
            int CompletedTasks = 0;
            bool isMadmate = madmateCount && playerInfo.Object == Madmate.madmate && CachedPlayer.LocalPlayer.PlayerControl == Madmate.madmate;
            if (!playerInfo.Disconnected && playerInfo.Tasks != null &&
                playerInfo.Object &&
                playerInfo.Role && playerInfo.Role.TasksCountTowardProgress &&
                (playerInfo.Object != Madmate.madmate || isMadmate) &&
                !playerInfo.Object.hasFakeTasks()
                ) {
                bool isOldTaskMasterEx = TaskMaster.taskMaster && TaskMaster.oldTaskMasterPlayerId == playerInfo.PlayerId;
                bool isTaskMasterEx = TaskMaster.taskMaster && TaskMaster.taskMaster == playerInfo.Object && TaskMaster.isTaskComplete;
                if (isOldTaskMasterEx || (!isResult && isTaskMasterEx)) {
                } else {
                    foreach (var playerInfoTask in playerInfo.Tasks.GetFastEnumerator()) {
                        if (playerInfoTask.Complete) CompletedTasks++;
                        TotalTasks++;
                    }
                }
                if (isMadmate)
                    TotalTasks = MadmateTaskHelper.madmateTasks;
            }
            return Tuple.Create(CompletedTasks, TotalTasks);
        }
                public static Tuple<int, int> taskInfo(GameData.PlayerInfo playerInfo) {
            int TotalTasks = 0;
            int CompletedTasks = 0;
            if (!playerInfo.Disconnected && playerInfo.Tasks != null &&
                playerInfo.Object &&
                playerInfo.Role && playerInfo.Role.TasksCountTowardProgress &&
                !playerInfo.Object.hasFakeTasks() && !playerInfo.Role.IsImpostor
                ) {
                foreach (var playerInfoTask in playerInfo.Tasks.GetFastEnumerator())
                {
                    if (playerInfoTask.Complete) CompletedTasks++;
                    TotalTasks++;
                }
                
            }
            return Tuple.Create(CompletedTasks, TotalTasks);
        }
        

        [HarmonyPatch(typeof(GameData), nameof(GameData.RecomputeTaskCounts))]
        private static class GameDataRecomputeTaskCountsPatch {
            private static bool Prefix(GameData __instance) {
               

                var totalTasks = 0;
                var completedTasks = 0;
                
                foreach (var playerInfo in GameData.Instance.AllPlayers.GetFastEnumerator())
                {
                    if (playerInfo.Object
                        && playerInfo.Object.hasAliveKillingLover() // Tasks do not count if a Crewmate has an alive killing Lover
                        || playerInfo.PlayerId == Lawyer.lawyer?.PlayerId // Tasks of the Lawyer do not count
                        || (playerInfo.PlayerId == Pursuer.pursuer?.PlayerId && Pursuer.pursuer.Data.IsDead) // Tasks of the Pursuer only count, if he's alive
                        || playerInfo.PlayerId == Thief.thief?.PlayerId // Thief's tasks only count after joining crew team as sheriff (and then the thief is not the thief anymore)
                       )
                        continue;
                    var (playerCompleted, playerTotal) = taskInfo(playerInfo);
                    totalTasks += playerTotal;
                    completedTasks += playerCompleted;
                }
                
                __instance.TotalTasks = totalTasks;
                __instance.CompletedTasks = completedTasks;
                return false;
            }
        }

        internal class tasks
        {
        }

    }
}
