using Xunit;
using ReaderWriterLocksSample.Core;

namespace ReaderWriterLocksSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsLockMessage()
    {
        var handler = new Handler();
        Assert.Contains("lock", handler.Process());
    }
    
    [Fact]
    public void ProtectedData_ReadsAndWrites()
    {
        var data = new ProtectedData();
        
        data.Write(42);
        Assert.Equal(42, data.Read());
        
        data.Write(100);
        Assert.Equal(100, data.Read());
    }
}
