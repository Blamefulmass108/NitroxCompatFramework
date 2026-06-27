using System;
using HarmonyLib;

namespace NitroxCompatFramework.Patches;

[HarmonyPatch(typeof(GameInput), "GetBinding")]
internal static class GameInputBindingPatch
{
	private static Exception Finalizer(ref string __result, Exception __exception)
	{
		if (__exception == null)
		{
			return null;
		}
		__result = string.Empty;
		return null;
	}
}
