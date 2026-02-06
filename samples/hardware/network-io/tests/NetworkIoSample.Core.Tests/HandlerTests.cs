using Xunit;
using NetworkIoSample.Core;

namespace NetworkIoSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("Network", handler.Process());
    }
    
    [Fact]
    public void NetworkSocket_Connects()
    {
        var socket = new NetworkSocket();
        socket.Connect("127.0.0.1", 8080);
        
        Assert.True(socket.IsConnected);
        Assert.Equal("127.0.0.1", socket.RemoteAddress);
    }
    
    [Fact]
    public void NetworkSocket_SendsMessages()
    {
        var socket = new NetworkSocket();
        socket.Connect("localhost", 5000);
        socket.SendMessage("Hello");
        
        var messages = socket.GetSentMessages().ToList();
        Assert.Single(messages);
    }
}
