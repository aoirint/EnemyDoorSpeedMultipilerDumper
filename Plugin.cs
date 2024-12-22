using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace EnemyDoorSpeedMultipilerDumper;

[BepInPlugin("com.aoirint.enemydoorspeedmultipilerdumper", "Enemy Door Speed Multipiler Dumper", "0.1.0")]
[BepInProcess("Lethal Company.exe")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
        
    private void Awake()
    {
        Logger = base.Logger;
        Logger.LogInfo("Plugin com.aoirint.enemydoorspeedmultipilerdumper is loaded!");

        Harmony.CreateAndPatchAll(typeof(Plugin));
    }

    [HarmonyPatch(typeof(RoundManager), "Awake")]
    [HarmonyPostfix]
    static void RoundManagerAwakePostfix() {
        var currentLevel = RoundManager.Instance.currentLevel;
        if (currentLevel == null) {
            Logger.LogInfo("currentLevel is null");
            return;
        }

        var enemies = currentLevel.Enemies;

        foreach (var enemy in enemies) {
            Logger.LogInfo($"{enemy.enemyType.enemyName},{enemy.enemyType.doorSpeedMultiplier}");
        }
    }
}
