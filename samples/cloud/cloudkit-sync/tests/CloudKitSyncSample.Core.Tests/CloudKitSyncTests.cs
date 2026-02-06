using CloudKitSyncSample.Core;

namespace CloudKitSyncSample.Core.Tests;

public sealed class CloudKitSyncTests
{
    [Fact]
    public void Push_StoresRecord()
    {
        var sync = new CloudKitSync();
        var record = new SyncRecord("1", "data", DateTimeOffset.UtcNow);

        sync.Push(record);

        Assert.Single(sync.FetchAll());
    }
}
