namespace NetworkSocketsSample.Core;

public class Handler { public string Process() => "Network sockets ready"; }

public class SocketServer
{
    public class ConnectionInfo
    {
        public string RemoteAddress { get; set; } = string.Empty;
        public int Port { get; set; }
        public DateTime ConnectedAt { get; set; }
    }

    private readonly List<ConnectionInfo> _connections = new();

    public void AddConnection(string addr, int port)
    {
        _connections.Add(new ConnectionInfo { RemoteAddress = addr, Port = port, ConnectedAt = DateTime.Now });
    }

    public int ActiveConnections => _connections.Count;
    public IReadOnlyList<ConnectionInfo> GetConnections() => _connections.AsReadOnly();
}