namespace NitroxCompatFramework.Core;

internal sealed class DetectedPlugin
{
    public string Name { get; }
    public string Guid { get; }
    public string Version { get; }

    public DetectedPlugin(string name, string guid, string version)
    {
        Name = name;
        Guid = guid;
        Version = version;
    }
}