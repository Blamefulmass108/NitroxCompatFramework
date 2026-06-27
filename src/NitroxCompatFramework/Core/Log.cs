using BepInEx.Logging;

namespace NitroxCompatFramework.Core;

internal static class Log
{
    private static ManualLogSource _source;

    public static void Initialize(ManualLogSource source)
    {
        _source = source;
    }

    public static void Info(string message)
    {
        _source?.LogInfo("[NCF] " + message);
    }

    public static void Warning(string message)
    {
        _source?.LogWarning("[NCF] " + message);
    }

    public static void Error(string message)
    {
        _source?.LogError("[NCF] " + message);
    }
}