using GcdAsyncSample.Core;

namespace GcdAsyncSample.Core.Tests;

public sealed class DispatchQueueTests
{
    [Fact]
    public async Task ProcessAsync_CallsHandler()
    {
        var queue = new DispatchQueue();
        queue.Enqueue(new DispatchTask { Name = "Test" });

        int called = 0;
        await queue.ProcessAsync(_ =>
        {
            called++;
            return Task.CompletedTask;
        });

        Assert.Equal(1, called);
    }
}
