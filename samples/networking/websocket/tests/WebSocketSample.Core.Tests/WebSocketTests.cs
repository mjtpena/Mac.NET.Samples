using Xunit;
using WebSocketSample.Core;
namespace WebSocketSample.Core.Tests;
public class WebSocketTests {
    [Fact] public async Task SendMessage_StoresMessage() {
        var ws = new WebSocketServer();
        await ws.SendMessage("hello");
        Assert.Equal(1, ws.GetMessageCount());
    }
}