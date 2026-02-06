using IOKitSample.Core;

namespace IOKitSample.Core.Tests;

public sealed class HardwareRegistryTests
{
    [Fact]
    public void Register_StoresDevice()
    {
        var registry = new HardwareRegistry();
        var device = new HardwareDevice("CPU", "M3", "Active");

        registry.Register(device);

        Assert.Single(registry.ListAll());
    }
}
