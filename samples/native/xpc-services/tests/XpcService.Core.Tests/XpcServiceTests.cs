using XpcService.Core;

namespace XpcService.Core.Tests;

public sealed class XpcMessageTests
{
    [Fact]
    public void Create_SetsTimestamp()
    {
        var msg = XpcMessage.Create("test", "payload");

        Assert.Equal("test", msg.Type);
        Assert.Equal("payload", msg.Payload);
        Assert.True(msg.Timestamp > 0);
    }

    [Fact]
    public void IsValid_ReturnsFalseForEmptyType()
    {
        var msg = new XpcMessage("", "payload", 1000);

        Assert.False(msg.IsValid());
    }

    [Fact]
    public void IsValid_ReturnsTrueForValidMessage()
    {
        var msg = XpcMessage.Create("ping", "");

        Assert.True(msg.IsValid());
    }
}

public sealed class MessageRouterTests
{
    [Fact]
    public void Route_CallsRegisteredHandler()
    {
        var router = new MessageRouter();
        router.Register("ping", _ => "pong");

        var msg = XpcMessage.Create("ping", "");
        var response = router.Route(msg);

        Assert.Equal("pong", response);
    }

    [Fact]
    public void Route_PassesPayload()
    {
        var router = new MessageRouter();
        router.Register("echo", payload => payload);

        var msg = XpcMessage.Create("echo", "hello");
        var response = router.Route(msg);

        Assert.Equal("hello", response);
    }

    [Fact]
    public void Route_UnknownType_ReturnsError()
    {
        var router = new MessageRouter();

        var msg = XpcMessage.Create("unknown", "");
        var response = router.Route(msg);

        Assert.Contains("Unknown", response, StringComparison.OrdinalIgnoreCase);
    }
}
