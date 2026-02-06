using Xunit;
using MetalSample.Core;
namespace MetalSample.Core.Tests;
public class MetalTests {
    [Fact] public void Device_IsAvailable() {
        var dev = new MetalDevice();
        Assert.True(dev.IsAvailable);
    }
}