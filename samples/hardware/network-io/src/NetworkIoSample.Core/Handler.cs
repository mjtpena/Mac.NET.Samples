namespace NetworkIoSample.Core;

/// <summary>
/// Network I/O operations.
/// </summary>
public class Handler
{
    public string Process() => "Network I/O operations ready";
}

public class NetworkSocket
{
    public string RemoteAddress { get; set; } = string.Empty;
    public int RemotePort { get; set; }
    public bool IsConnected { get; set; }
    private readonly List<string> _messages = new();
    
    public void Connect(string address, int port)
    {
        RemoteAddress = address;
        RemotePort = port;
        IsConnected = true;
    }
    
    public void Disconnect()
    {
        IsConnected = false;
        _messages.Clear();
    }
    
    public void SendMessage(string message)
    {
        if (IsConnected)
            _messages.Add(message);
    }
    
    public IEnumerable<string> GetSentMessages() => _messages.AsReadOnly();
}
