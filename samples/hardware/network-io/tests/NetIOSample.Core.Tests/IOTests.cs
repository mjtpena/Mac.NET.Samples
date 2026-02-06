using Xunit;
using NetIOSample.Core;
namespace NetIOSample.Core.Tests;
public class IOTests {
    [Fact] public void Initialize_SetsFlag() {
        var io = new NetworkIO();
        io.Initialize();
        Assert.True(io.IsInitialized);
    }
}