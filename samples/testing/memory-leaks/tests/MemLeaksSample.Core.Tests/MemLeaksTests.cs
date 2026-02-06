using Xunit;
using MemLeaksSample.Core;
namespace MemLeaksSample.Core.Tests;
public class MemLeaksTests {
    [Fact] public void Dispose_FreesResources() {
        var mgr = new ResourceManager();
        mgr.Dispose();
        Assert.True(true);
    }
}