using System;
using HarmonyLib;

namespace NitroxCompatFramework.Patches;

[HarmonyPatch(typeof(GameInput), "GetButtonDown")]
internal static class GameInputGetButtonDownPatch
{
	private static Exception Finalizer(ref bool __result, Exception __exception)
	{
		if (__exception == null)
		{
			return null;
		}
		__result = false;
		return null;
	}
}
