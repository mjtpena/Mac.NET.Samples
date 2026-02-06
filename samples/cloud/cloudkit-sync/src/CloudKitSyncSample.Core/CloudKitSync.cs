namespace CloudKitSyncSample.Core;

public sealed record SyncRecord(string Id, string Data, DateTimeOffset ModifiedAt);

public sealed class CloudKitSync
{
    private readonly List<SyncRecord> _records = new();

    public void Push(SyncRecord record)
    {
        _records.Add(record);
    }

    public IReadOnlyList<SyncRecord> FetchAll() => _records.AsReadOnly();
}
