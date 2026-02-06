using Xunit;
using ObjcRuntimeSample.Core;

namespace ObjcRuntimeSample.Core.Tests;

public class ObjcBridgeTests
{
    [Fact]
    public void GetProcessName_ReturnsValidString()
    {
        var result = Handler.ObjCBridge.GetProcessName();
        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }
}