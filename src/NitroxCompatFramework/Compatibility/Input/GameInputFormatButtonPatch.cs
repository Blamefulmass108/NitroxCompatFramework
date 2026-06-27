using System;
using HarmonyLib;

namespace NitroxCompatFramework.Patches;

[HarmonyPatch(typeof(GameInput), "FormatButton", new Type[]
{
	typeof(GameInput.Button),
	typeof(bool)
})]
internal static class GameInputFormatButtonPatch
{
	private static Exception Finalizer(GameInput.Button action, bool allBindingSets, ref string __result, Exception __exception)
	{
		if (__exception == null)
		{
			return null;
		}
		__result = string.Empty;
		return null;
	}
}
