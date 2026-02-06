using Xunit;
using CloudKitSyncSample.Core;
namespace CloudKitSyncSample.Core.Tests;
public class CloudKitTests {
    [Fact] public void Push_StoresRecord() {
        var sync = new CloudKitSync(); sync.Push("rec1", "data");
        var rec = sync.Fetch("rec1"); Assert.NotNull(rec); Assert.Equal("data", rec.Data);
    }
}