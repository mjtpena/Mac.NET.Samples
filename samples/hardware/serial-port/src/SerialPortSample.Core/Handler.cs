namespace SerialPortSample.Core;

/// <summary>
/// Serial port communication.
/// </summary>
public class Handler
{
    public string Process() => "Serial port communication ready";
}

public class SerialPortConnection
{
    public string Port { get; set; } = string.Empty;
    public int BaudRate { get; set; } = 9600;
    public bool IsOpen { get; set; }
    private readonly List<string> _receivedData = new();
    
    public void Open()
    {
        IsOpen = true;
    }
    
    public void Close()
    {
        IsOpen = false;
        _receivedData.Clear();
    }
    
    public void Write(string data)
    {
        if (IsOpen)
            _receivedData.Add(data);
    }
    
    public IEnumerable<string> GetReceivedData() => _receivedData.AsReadOnly();
}
