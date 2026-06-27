using NitroxCompatFramework.Core;

namespace NitroxCompatFramework.Diagnostics;

internal static class StartupReport
{
    public static void Print()
    {
        Log.Info("==================================================");
        Log.Info(NcfInfo.Banner);
        Log.Info($"Author: {NcfInfo.Author}");
        Log.Info($"Target Nitrox: {NcfInfo.SupportedNitrox}");
        Log.Info($"Target Nautilus: {NcfInfo.SupportedNautilus}");
        Log.Info("Compatibility layer ready.");
        Log.Info("==================================================");
    }
}