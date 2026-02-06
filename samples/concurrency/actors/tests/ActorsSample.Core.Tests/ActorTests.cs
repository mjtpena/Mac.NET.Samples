using Xunit;
using ActorsSample.Core;

namespace ActorsSample.Core.Tests;

public class ActorTests
{
    [Fact]
    public async Task Send_IncrementsMessageCount()
    {
        var actor = new SimpleActor();
        await actor.SendAsync(new ActorMessage(1, "data"));
        Assert.Equal(1, actor.MessageCount);
    }
}