using Xunit;
using MemoryProfilingSample.Core;

namespace MemoryProfilingSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("Memory", handler.Process());
    }
    
    [Fact]
    public void MemoryProfiler_TakesSnapshots()
    {
        var profiler = new MemoryProfiler();
        profiler.TakeSnapshot();
        profiler.TakeSnapshot();
        
        Assert.Equal(2, profiler.GetSnapshots().Count());
    }
}
