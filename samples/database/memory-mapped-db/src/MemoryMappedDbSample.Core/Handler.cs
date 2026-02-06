namespace MemMapDbSample.Core;

/// <summary>
/// Memory-mapped file database operations.
/// </summary>
public class Handler
{
    public string Process() => "Memory-mapped database ready";
}

public class MemoryMappedStorage
{
    private readonly Dictionary<string, byte[]> _data = new();
    private long _totalSize;
    
    public void Store(string key, byte[] value)
    {
        if (_data.TryGetValue(key, out var old))
            _totalSize -= old.Length;
        
        _data[key] = value;
        _totalSize += value.Length;
    }
    
    public byte[]? Retrieve(string key) => 
        _data.TryGetValue(key, out var data) ? data : null;
    
    public void Delete(string key)
    {
        if (_data.TryGetValue(key, out var data))
        {
            _totalSize -= data.Length;
            _data.Remove(key);
        }
    }
    
    public long GetTotalSize() => _totalSize;
    public int GetItemCount() => _data.Count;
}
