using HarmonyLib;

namespace NitroxCompatFramework.Core;

internal static class ReflectionHelper
{
    public static T GetField<T>(object instance, string name)
    {
        var field = AccessTools.Field(instance.GetType(), name);

        return (T)field.GetValue(instance);
    }

    public static void SetField<T>(object instance, string name, T value)
    {
        var field = AccessTools.Field(instance.GetType(), name);

        field.SetValue(instance, value);
    }
}