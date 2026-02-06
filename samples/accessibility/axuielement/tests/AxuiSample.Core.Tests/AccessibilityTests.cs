using Xunit;
using AxuiSample.Core;
namespace AxuiSample.Core.Tests;
public class AccessibilityTests {
    [Fact] public void RegisterElement_TracksElement() {
        var auto = new AccessibilityAutomation();
        auto.RegisterElement("button", "Click Me", true);
        Assert.Equal(1, auto.GetElementCount());
    }
}