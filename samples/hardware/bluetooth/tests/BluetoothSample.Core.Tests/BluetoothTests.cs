using Xunit;
using BluetoothSample.Core;
namespace BluetoothSample.Core.Tests;
public class BluetoothTests {
    [Fact] public void AddDevice_RecordsDevice() {
        var scanner = new BluetoothScanner();
        scanner.AddDevice("00:11:22:33:44:55", "Device1", -50);
        Assert.Equal(1, scanner.GetDeviceCount());
    }
}