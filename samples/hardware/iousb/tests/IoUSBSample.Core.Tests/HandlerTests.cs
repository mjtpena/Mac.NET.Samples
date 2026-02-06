using Xunit;
using IoUSBSample.Core;

namespace IoUSBSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("IOKit", handler.Process());
    }
    
    [Fact]
    public void IOUSBManager_RegistersDevices()
    {
        var manager = new IOUSBManager();
        var device = new IOUSBDevice { DeviceId = 1, BusNumber = 0 };
        
        manager.RegisterDevice(device);
        
        var retrieved = manager.GetDevice(1);
        Assert.NotNull(retrieved);
    }
    
    [Fact]
    public void IOUSBManager_FiltersConnectedDevices()
    {
        var manager = new IOUSBManager();
        
        manager.RegisterDevice(new IOUSBDevice { DeviceId = 1, IsConnected = true });
        manager.RegisterDevice(new IOUSBDevice { DeviceId = 2, IsConnected = false });
        
        var connected = manager.GetConnectedDevices().ToList();
        Assert.Single(connected);
    }
}
