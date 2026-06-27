using System;
using System.Reflection;
using HarmonyLib;
using NitroxCompatFramework.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NitroxCompatFramework.Compatibility.Input;

/// <summary>
/// Nitrox interrupts GameInputSystem.Initialize() before the gameplay
/// InputActionMap is enabled. This leaves keyboard and controller
/// gameplay input permanently disabled.
///
/// The exception is intentionally suppressed and the gameplay action
/// map is force-enabled to restore normal input functionality.
/// </summary>

[HarmonyPatch(typeof(GameInputSystem), nameof(GameInputSystem.Initialize))]
internal static class GameplayInputRecoveryPatch
{
    private static Exception Finalizer(GameInputSystem __instance, Exception __exception)
    {
        if (__exception != null)
        {
            Log.Warning("GameInputSystem.Initialize threw an exception. Beginning recovery.");
            Log.Warning(__exception.ToString());
        }

        try
        {
            var field = AccessTools.Field(typeof(GameInputSystem), "actionMapGameplay");
            // Nitrox leaves the gameplay action map constructed but disabled.

            InputActionMap map = field?.GetValue(__instance) as InputActionMap;

            if (map == null)
            {
                Log.Warning("Gameplay InputActionMap could not be located.");
                return null;
            }

            if (!map.enabled)
            {
                map.Enable();
                Log.Info("Gameplay InputActionMap enabled.");
            }
            else
            {
                Log.Info("Gameplay InputActionMap already enabled.");
            }
        }
        catch (Exception ex)
        {
            Log.Error("Failed to recover Gameplay InputActionMap.");
            Log.Error(ex.ToString());
        }

        // Suppress the original exception to allow the game to continue.
        return null;
    }
}