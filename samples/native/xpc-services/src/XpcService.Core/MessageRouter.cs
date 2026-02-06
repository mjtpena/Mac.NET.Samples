namespace XpcService.Core;

public sealed class MessageRouter
{
    private readonly Dictionary<string, Func<string, string>> _routes = new();

    public void Register(string messageType, Func<string, string> handler)
    {
        _routes[messageType] = handler;
    }

    public string Route(XpcMessage message)
    {
        if (!message.IsValid())
        {
            return "ERROR: Invalid message";
        }

        if (_routes.TryGetValue(message.Type, out var handler))
        {
            return handler(message.Payload);
        }

        return "ERROR: Unknown message type";
    }
}
