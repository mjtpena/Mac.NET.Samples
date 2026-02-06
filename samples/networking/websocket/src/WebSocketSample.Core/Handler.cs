namespace WebSocketSample.Core;
public class Handler { public string Process() => "WebSocket ready"; }
public class WebSocketServer {
    private List<string> _messages = new();
    public async Task SendMessage(string msg) { _messages.Add(msg); await Task.CompletedTask; }
    public int GetMessageCount() => _messages.Count;
}