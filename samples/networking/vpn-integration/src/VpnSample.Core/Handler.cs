namespace VpnSample.Core;
public class Handler { public string Process() => "VPN integration ready"; }
public class VpnClient {
    public bool IsConnected { get; private set; }
    public void Connect(string server) => IsConnected = !string.IsNullOrEmpty(server);
}