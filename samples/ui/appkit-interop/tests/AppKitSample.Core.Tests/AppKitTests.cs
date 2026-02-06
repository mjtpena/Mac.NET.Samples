using Xunit;
using AppKitSample.Core;
namespace AppKitSample.Core.Tests;
public class AppKitTests {
    [Fact] public void GetSystemAppearance_ReturnsValue() {
        var bridge = new AppKitBridge();
        Assert.NotNull(bridge.GetSystemAppearance());
    }
}