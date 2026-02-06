using CloudKitSyncSample.Core;

Console.WriteLine("[CloudKit Sync Sample]");

var sync = new CloudKitSync();
sync.Push(new SyncRecord("1", "Sample data", DateTimeOffset.UtcNow));

Console.WriteLine($"Records: {sync.FetchAll().Count}");
