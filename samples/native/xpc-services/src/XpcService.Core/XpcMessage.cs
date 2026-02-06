namespace XpcService.Core;

public sealed record XpcMessage(string Type, string Payload, long Timestamp)
{
    public static XpcMessage Create(string type, string payload)
    {
        return new XpcMessage(type, payload, DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }

    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Type) && Timestamp > 0;
    }
}
