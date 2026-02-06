namespace EncryptedDbSample.Core;
public class Handler { public string Process() => "Encrypted DB ready"; }
public class EncryptedStorage {
    private Dictionary<string, string> _data = new();
    private static string SimpleEncrypt(string s) => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(s));
    public void Store(string key, string value) => _data[key] = SimpleEncrypt(value);
    public string? Retrieve(string key) => _data.TryGetValue(key, out var v) ? v : null;
}