using Xunit;
using UsbSample.Core;

namespace UsbSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("USB", handler.Process());
    }
    
    [Fact]
    public void UsbManager_FindsDevicesBySerial()
    {
        var manager = new UsbManager();
        var device = new UsbDevice { VendorId = "0x1234", SerialNumber = "ABC123" };
        
        manager.RegisterDevice(device);
        
        var found = manager.FindDeviceBySerial("ABC123");
        Assert.NotNull(found);
    }
    
    [Fact]
    public void UsbManager_FindsDevicesByVendor()
    {
        var manager = new UsbManager();
        
        manager.RegisterDevice(new UsbDevice { VendorId = "0x1234", SerialNumber = "1" });
        manager.RegisterDevice(new UsbDevice { VendorId = "0x1234", SerialNumber = "2" });
        manager.RegisterDevice(new UsbDevice { VendorId = "0x5678", SerialNumber = "3" });
        
        var devices = manager.FindDevicesByVendor("0x1234").ToList();
        Assert.Equal(2, devices.Count);
    }
}
