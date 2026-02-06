using Xunit;
using BarriersSample.Core;

namespace BarriersSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsBarriersMessage()
    {
        var handler = new Handler();
        Assert.Contains("Barriers", handler.Process());
    }
    
    [Fact]
    public void SimpleBarrier_ThrowsOnInvalidCount()
    {
        Assert.Throws<ArgumentException>(() => new SimpleBarrier(0));
    }
    
    [Fact]
    public async Task SimpleBarrier_CoordinatesMultipleTasks()
    {
        var barrier = new SimpleBarrier(3);
        var signals = new List<int>();
        var lockObj = new object();
        
        var tasks = Enumerable.Range(0, 3).Select(async i =>
        {
            await barrier.SignalAndWaitAsync();
            lock (lockObj)
                signals.Add(i);
        }).ToList();
        
        await Task.WhenAll(tasks);
        Assert.Equal(3, signals.Count);
    }
}
