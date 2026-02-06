using Xunit;
using TouchSample.Core;
namespace TouchSample.Core.Tests;
public class TouchTests {
    [Fact] public void TouchDetected_CanBeSet() {
        var handler = new TouchHandler();
        handler.TouchDetected = true;
        Assert.True(handler.TouchDetected);
    }
}