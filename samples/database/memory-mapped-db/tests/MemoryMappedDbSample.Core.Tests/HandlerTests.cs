using Xunit;
using MemMapDbSample.Core;

namespace MemMapDbSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMemMapMessage()
    {
        var handler = new Handler();
        Assert.Contains("Memory-mapped", handler.Process());
    }
    
    [Fact]
    public void MemoryMappedStorage_StoresAndRetrieves()
    {
        var storage = new MemoryMappedStorage();
        var data = new byte[] { 1, 2, 3 };
        
        storage.Store("key1", data);
        var retrieved = storage.Retrieve("key1");
        
        Assert.NotNull(retrieved);
        Assert.Equal(data, retrieved);
    }
    
    [Fact]
    public void MemoryMappedStorage_TracksSize()
    {
        var storage = new MemoryMappedStorage();
        
        storage.Store("k1", new byte[100]);
        storage.Store("k2", new byte[50]);
        
        Assert.Equal(150, storage.GetTotalSize());
    }
}
