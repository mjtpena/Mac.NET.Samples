namespace DashStreamingSample.Core;
public class Handler { public string Process() => "DASH streaming ready"; }
public class DashClient {
    private Dictionary<int, int> _bitrates = new();
    public void RegisterBitrate(int quality, int kbps) => _bitrates[quality] = kbps;
    public int? GetBitrate(int quality) => _bitrates.TryGetValue(quality, out var b) ? b : null;
}