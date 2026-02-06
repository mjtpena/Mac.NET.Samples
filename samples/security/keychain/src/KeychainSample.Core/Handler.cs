namespace KeychainSample.Core;

public class Handler { public string Process() => "Keychain ready"; }

public record KeychainEntry(string Service, string Account, string Secret);

public class KeychainManager
{
    private readonly Dictionary<string, KeychainEntry> _store = new();

    public bool Add(KeychainEntry entry)
    {
        if (string.IsNullOrEmpty(entry.Service) || string.IsNullOrEmpty(entry.Account))
            return false;
        _store[$"{entry.Service}:{entry.Account}"] = entry;
        return true;
    }

    public KeychainEntry? Query(string service, string account)
    {
        var key = $"{service}:{account}";
        return _store.TryGetValue(key, out var entry) ? entry : null;
    }

    public bool Remove(string service, string account)
    {
        return _store.Remove($"{service}:{account}");
    }
}