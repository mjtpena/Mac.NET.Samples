namespace NetworkFrameworkSample.Core;
public class Handler { public string Process() => "Network framework ready"; }
public class NetworkConnection {
    public bool IsConnected { get; private set; }
    public void Connect(string host, int port) => IsConnected = !string.IsNullOrEmpty(host);
    public void Disconnect() => IsConnected = false;
}