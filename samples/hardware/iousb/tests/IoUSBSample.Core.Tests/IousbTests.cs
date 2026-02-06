using Xunit;
using IousbSample.Core;
namespace IousbSample.Core.Tests;
public class IousbTests {
    [Fact] public void GetDescription_ReturnsText() {
        var iface = new UsbInterface();
        Assert.NotNull(iface.GetDescription());
    }
}