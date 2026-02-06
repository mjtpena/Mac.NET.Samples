using Xunit;
using BluetoothSample.Core;

namespace BluetoothSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("Bluetooth", handler.Process());
    }
    
    [Fact]
    public void BluetoothManager_PairsDevices()
    {
        var manager = new BluetoothManager();
        var device = new BluetoothDevice { Name = "Device1", Address = "11:22:33:44:55:66" };
        
        manager.AddDiscoveredDevice(device);
        var paired = manager.PairDevice("11:22:33:44:55:66");
        
        Assert.True(paired);
        Assert.Single(manager.GetPairedDevices());
    }
}
