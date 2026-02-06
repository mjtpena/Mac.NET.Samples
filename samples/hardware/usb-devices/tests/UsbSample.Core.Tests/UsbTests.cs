using Xunit;
using UsbSample.Core;
namespace UsbSample.Core.Tests;
public class UsbTests {
    [Fact] public void EnumerateDevices_Succeeds() {
        var mgr = new UsbManager();
        mgr.EnumerateDevices();
        Assert.True(true);
    }
}