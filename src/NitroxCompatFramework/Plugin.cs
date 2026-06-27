using BepInEx;
using HarmonyLib;
using NitroxCompatFramework.Core;
using NitroxCompatFramework.Diagnostics;
using System.Collections;
using UnityEngine;
    
namespace NitroxCompatFramework;

[BepInPlugin(NcfInfo.Guid, NcfInfo.Name, NcfInfo.Version)]
public sealed class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Log.Initialize(Logger);

        StartupReport.Print();

        Harmony harmony = new Harmony(NcfInfo.Guid);
        harmony.PatchAll();

        Log.Info("Harmony patches applied.");
        Log.Info($"{NcfInfo.Banner} initialized successfully.");
    }

    private IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(2f);
        CompatibilityReport.Print();
    }
}