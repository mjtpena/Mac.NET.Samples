using Xunit;
using NetExtSample.Core;
namespace NetExtSample.Core.Tests;
public class ExtTests {
    [Fact] public void IsActive_CanBeSet() {
        var ext = new NetworkExtension();
        ext.IsActive = true;
        Assert.True(ext.IsActive);
    }
}