using System;
using HarmonyLib;
using UnityEngine;

namespace NitroxCompatFramework.Patches;

[HarmonyPatch(typeof(GameInput), "get_PrimaryDevice")]
internal static class GameInputPrimaryDevicePatch
{
	private static Exception Finalizer(ref GameInput.Device __result, Exception __exception)
	{
		if (__exception == null)
		{
			return null;
		}
		try
		{
			string[] joystickNames = Input.GetJoystickNames();
			if (joystickNames != null && joystickNames.Length != 0)
			{
				__result = GameInput.Device.Controller;
			}
			else
			{
				__result = GameInput.Device.Keyboard;
			}
		}
		catch
		{
			__result = GameInput.Device.Keyboard;
		}
		return null;
	}
}
