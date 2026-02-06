namespace KeychainSample.Core;

public static class KeychainFormatter
{
    public static string FormatDisplay(KeychainEntry entry)
    {
        return $"Service: {entry.Service} | Account: {entry.Account}";
    }
}
