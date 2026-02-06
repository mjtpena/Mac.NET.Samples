using Xunit;
using MacCatalystSample.Core;
namespace MacCatalystSample.Core.Tests;
public class CatalystTests {
    [Fact] public void Platform_IsMacOS_IOS() {
        var app = new CatalystApp();
        Assert.Contains("macOS", app.Platform);
    }
}