using NitroxCompatFramework.Core;

namespace NitroxCompatFramework.Diagnostics;

internal static class CompatibilityReport
{
    public static void Print()
    {
        Log.Info("Detected plugin environment:");

        Report("Nitrox", "nitrox.subnautica");
        Report("Nautilus", "com.snmodding.nautilus", CompatibilityVersions.Nautilus);
        Report("Vehicle Framework", "com.mikjaw.subnautica.vehicleframework.mod", CompatibilityVersions.VehicleFramework);
        Report("Configuration Manager", "Tobey.BepInEx.ConfigurationManager.Subnautica");

        Log.Info("Loaded plugins:");

        foreach (DetectedPlugin plugin in PluginDetector.GetLoadedPlugins())
        {
            Log.Info($"- {plugin.Name} {plugin.Version} ({plugin.Guid})");
        }
    }

    private static void Report(string displayName, string guid, string testedVersion = null)
    {
        if (PluginDetector.TryGetPlugin(guid, out DetectedPlugin plugin))
        {
            Log.Info($"{displayName}: detected {plugin.Version}");

            if (testedVersion != null && plugin.Version != testedVersion)
            {
                Log.Warning(
                    $"{displayName} {plugin.Version} detected. " +
                    $"Tested version is {testedVersion}."
                );
            }

            return;
        }

        Log.Info($"{displayName}: not detected");
    }
}