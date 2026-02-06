using Xunit;
using ThreadPoolSample.Core;

namespace ThreadPoolSample.Core.Tests;

public class HandlerTests : IDisposable
{
    [Fact]
    public void Process_ReturnsThreadPoolMessage()
    {
        var handler = new Handler();
        Assert.Contains("thread pool", handler.Process());
    }
    
    [Fact]
    public void SimpleThreadPool_ExecutesWorkItems()
    {
        using (var pool = new SimpleThreadPool(2))
        {
            var count = 0;
            var lockObj = new object();
            
            for (int i = 0; i < 3; i++)
            {
                pool.QueueWorkItem(async () =>
                {
                    await Task.Delay(5);
                    lock (lockObj)
                        count++;
                });
            }
            
            Thread.Sleep(50);
            Assert.Equal(3, count);
        }
    }
    
    public void Dispose() { }
}
