using System;
using HarmonyLib;

namespace NitroxCompatFramework.Patches;

[HarmonyPatch(typeof(GameInputSystem), "Initialize")]
internal static class GameInputSystemInitializePatch
{
    private static Exception Finalizer(GameInputSystem __instance, Exception __exception)
    {
        if (__exception != null)
        {
            UnityEngine.Debug.LogError("[NCF] GameInputSystem.Initialize threw and was suppressed:\n" + __exception);
        }

        try
        {
            var mapField = AccessTools.Field(typeof(GameInputSystem), "actionMapGameplay");
            var map = mapField?.GetValue(__instance) as UnityEngine.InputSystem.InputActionMap;

            if (map != null && !map.enabled)
            {
                map.Enable();
                UnityEngine.Debug.Log("[NCF] Forced Gameplay InputActionMap enabled from Initialize finalizer.");
            }
            else
            {
                UnityEngine.Debug.Log("[NCF] Gameplay map force-enable skipped. map=" + map + " enabled=" + (map != null && map.enabled));
            }
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.LogWarning("[NCF] Failed to force-enable Gameplay map from finalizer: " + ex);
        }

        return null;
    }
}