using Xunit;
using PinvokeSample.Core;
namespace PinvokeSample.Core.Tests;
public class PinvokeTests {
    [Fact] public void CallNative_ReturnsValue() {
        var result = NativeLib.CallNative();
        Assert.Equal(42, result);
    }
}