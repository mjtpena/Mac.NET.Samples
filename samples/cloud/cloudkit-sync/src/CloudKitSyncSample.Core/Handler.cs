namespace CloudKitSyncSample.Core;
public class Handler { public string Process() => "CloudKit ready"; }
public record SyncRecord(string Id, string Data, DateTime SyncedAt);
public class CloudKitSync {
    private readonly List<SyncRecord> _records = new();
    public void Push(string id, string data) => _records.Add(new(id, data, DateTime.Now));
    public SyncRecord? Fetch(string id) => _records.FirstOrDefault(r => r.Id == id);
    public int GetRecordCount() => _records.Count;
}