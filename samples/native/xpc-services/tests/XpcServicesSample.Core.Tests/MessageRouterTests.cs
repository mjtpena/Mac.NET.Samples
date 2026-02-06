using Xunit;
using XpcServicesSample.Core;

namespace XpcServicesSample.Core.Tests;

public class MessageRouterTests
{
    [Fact]
    public void Route_WithValidMessage_CallsHandler()
    {
        var router = new MessageRouter();
        router.Register("ping", m => "pong");
        
        var msg = new XpcMessage("ping", "test");
        var result = router.Route(msg);
        
        Assert.Equal("pong", result);
    }

    [Fact]
    public void Route_WithInvalidMessage_ReturnsError()
    {
        var router = new MessageRouter();
        var msg = new XpcMessage("", "");
        
        var result = router.Route(msg);
        Assert.Equal("Invalid message", result);
    }

    [Fact]
    public void Route_WithUnregisteredType_ReturnsNoHandler()
    {
        var router = new MessageRouter();
        var msg = new XpcMessage("unknown", "data");
        
        var result = router.Route(msg);
        Assert.Equal("No handler", result);
    }
}