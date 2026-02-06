namespace DefaultsSample.Core;
public class Handler { public string Process() => "System defaults ready"; }
public class DefaultsManager {
    private Dictionary<string, object> _defaults = new();
    public void SetDefault(string key, object value) => _defaults[key] = value;
    public object? GetDefault(string key) => _defaults.TryGetValue(key, out var v) ? v : null;
}