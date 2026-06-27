using System;
using HarmonyLib;

namespace NitroxCompatFramework.Patches;

[HarmonyPatch(typeof(GameInput), "HasFlag")]
internal static class GameInputHasFlagPatch
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
