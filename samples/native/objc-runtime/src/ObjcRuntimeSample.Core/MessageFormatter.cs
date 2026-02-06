namespace ObjcRuntimeSample.Core;

public static class MessageFormatter
{
    public static string Format(string processName, string osVersion)
    {
        var safeProcess = string.IsNullOrWhiteSpace(processName) ? "(unknown)" : processName.Trim();
        var safeVersion = string.IsNullOrWhiteSpace(osVersion) ? "(unknown)" : osVersion.Trim();
        return $"Process: {safeProcess} | macOS: {safeVersion}";
    }
}
