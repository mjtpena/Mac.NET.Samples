using Xunit;
using ChannelMessagingSample.Core;

namespace ChannelMessagingSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsChannelMessage()
    {
        var handler = new Handler();
        Assert.Contains("Channel", handler.Process());
    }
    
    [Fact]
    public async Task MessageBroker_PublishesMessages()
    {
        var broker = new MessageBroker();
        var msg = new Message(Guid.NewGuid().ToString(), "Test", DateTime.UtcNow);
        
        await broker.PublishAsync(msg);
        var received = await broker.ConsumeAsync().FirstAsync();
        
        Assert.Equal(msg.Id, received.Id);
    }
}
