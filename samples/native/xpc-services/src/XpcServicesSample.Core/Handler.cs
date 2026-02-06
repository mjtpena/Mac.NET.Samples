namespace XpcServicesSample.Core;

public class Handler
{
    public string Process() => "XPC services ready";
}

public record XpcMessage(string Type, string Payload)
{
    public bool IsValid() => !string.IsNullOrWhiteSpace(Type) && !string.IsNullOrWhiteSpace(Payload);
}

public class MessageRouter
{
    private readonly Dictionary<string, Func<XpcMessage, string>> _handlers = new();

    public void Register(string messageType, Func<XpcMessage, string> handler)
    {
        _handlers[messageType] = handler;
    }

    public string Route(XpcMessage message)
    {
        if (!message.IsValid()) return "Invalid message";
        if (_handlers.TryGetValue(message.Type, out var handler))
            return handler(message);
        return "No handler";
    }
}