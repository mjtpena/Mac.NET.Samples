using Xunit;
using FinderSyncSample.Core;
namespace FinderSyncSample.Core.Tests;
public class FinderTests {
    [Fact] public void SyncEnabled_CanBeSet() {
        var fs = new FinderSync();
        fs.SyncEnabled = true;
        Assert.True(fs.SyncEnabled);
    }
}