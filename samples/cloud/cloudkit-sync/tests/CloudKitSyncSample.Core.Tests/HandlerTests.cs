using Xunit;
using CloudKitSyncSample.Core;

namespace CloudKitSyncSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsInitializedMessage()
    {
        var handler = new Handler();
        Assert.Contains("CloudKit", handler.Process());
    }
    
    [Fact]
    public void CloudRecord_GeneratesUniqueId()
    {
        var r1 = new CloudRecord();
        var r2 = new CloudRecord();
        Assert.NotEqual(r1.Id, r2.Id);
    }
    
    [Fact]
    public void CloudKitSyncManager_SyncsRecords()
    {
        var manager = new CloudKitSyncManager();
        var record = new CloudRecord { Name = "Test" };
        manager.AddRecord(record);
        
        var success = manager.SyncRecord(record.Id);
        
        Assert.True(success);
        Assert.Equal(1, manager.GetSyncedCount());
        Assert.Equal(SyncStatus.Synced, manager.GetRecord(record.Id)!.Status);
    }
}
