using System.Collections.Generic;
using BepInEx.Bootstrap;

namespace NitroxCompatFramework.Core;

internal static class PluginDetector
{
    public static bool TryGetPlugin(string guid, out DetectedPlugin plugin)
    {
        plugin = null;

        if (!Chainloader.PluginInfos.TryGetValue(guid, out var info))
            return false;

        plugin = new DetectedPlugin(
            info.Metadata.Name,
            info.Metadata.GUID,
            info.Metadata.Version.ToString()
        );

        return true;
    }

    public static IEnumerable<DetectedPlugin> GetLoadedPlugins()
    {
        foreach (var info in Chainloader.PluginInfos.Values)
        {
            yield return new DetectedPlugin(
                info.Metadata.Name,
                info.Metadata.GUID,
                info.Metadata.Version.ToString()
            );
        }
    }
}