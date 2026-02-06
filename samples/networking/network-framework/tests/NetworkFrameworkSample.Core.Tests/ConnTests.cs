using Xunit;
using NetworkFrameworkSample.Core;
namespace NetworkFrameworkSample.Core.Tests;
public class ConnTests {
    [Fact] public void Connect_EstablishesConnection() {
        var conn = new NetworkConnection();
        conn.Connect("localhost", 8080);
        Assert.True(conn.IsConnected);
    }
}