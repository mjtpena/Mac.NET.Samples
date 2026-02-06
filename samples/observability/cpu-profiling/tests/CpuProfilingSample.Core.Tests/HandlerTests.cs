using Xunit;
using CpuProfilingSample.Core;

namespace CpuProfilingSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("CPU", handler.Process());
    }
    
    [Fact]
    public void CpuProfiler_MeasuresOperation()
    {
        var profiler = new CpuProfiler();
        
        using (profiler.MeasureOperation("test"))
            System.Threading.Thread.Sleep(10);
        
        Assert.True(profiler.GetTotalTime("test").TotalMilliseconds >= 10);
        Assert.Equal(1, profiler.GetCallCount("test"));
    }
}
