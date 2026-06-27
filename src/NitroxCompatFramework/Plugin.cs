using BepInEx;
using HarmonyLib;

namespace NitroxCompatFramework;

[BepInPlugin("blamefulmass108.subnautica.nitroxcompatframework", "Nitrox Compat Framework", "0.2.0")]
public class Plugin : BaseUnityPlugin
{
	private void Awake()
	{
		// gameObject.AddComponent<InputStateProbe>();
		Logger.LogInfo("Nitrox Compat Framework loaded.");
		Harmony harmony = new Harmony("blamefulmass108.subnautica.nitroxcompatframework");
		harmony.PatchAll();
		Logger.LogInfo((object)"Nitrox Compat Framework patches applied.");
	}
}