using Xunit;
using NetworkSocketsSample.Core;

namespace NetworkSocketsSample.Core.Tests;

public class SocketTests
{
    [Fact]
    public void AddConnection_TracksConnection()
    {
        var server = new SocketServer();
        server.AddConnection("127.0.0.1", 8080);
        
        Assert.Equal(1, server.ActiveConnections);
        var conns = server.GetConnections();
        Assert.Equal("127.0.0.1", conns[0].RemoteAddress);
        Assert.Equal(8080, conns[0].Port);
    }
}