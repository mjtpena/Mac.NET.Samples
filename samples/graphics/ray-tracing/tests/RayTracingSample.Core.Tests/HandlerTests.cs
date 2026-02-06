using Xunit;
using RayTracingSample.Core;

namespace RayTracingSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsReady()
    {
        var handler = new Handler();
        var result = handler.Process();
        Assert.Equal("Ready", result);
    }
}