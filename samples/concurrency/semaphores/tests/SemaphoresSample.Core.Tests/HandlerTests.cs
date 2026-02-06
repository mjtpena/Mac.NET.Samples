using Xunit;
using SemaphoresSample.Core;

namespace SemaphoresSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("Semaphore", handler.Process());
    }
    
    [Fact]
    public void ResourcePool_AcquiresAndReleases()
    {
        var pool = new ResourcePool<string>(new[] { "r1", "r2" });
        
        var resource = pool.AcquireResource();
        Assert.NotNull(resource);
        
        pool.ReleaseResource(resource);
    }
}
