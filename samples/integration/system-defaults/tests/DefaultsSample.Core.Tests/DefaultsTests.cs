using Xunit;
using DefaultsSample.Core;
namespace DefaultsSample.Core.Tests;
public class DefaultsTests {
    [Fact] public void SetDefault_Then_GetDefault() {
        var mgr = new DefaultsManager();
        mgr.SetDefault("theme", "dark");
        Assert.Equal("dark", mgr.GetDefault("theme"));
    }
}