using Xunit;
using KeychainSample.Core;

namespace KeychainSample.Core.Tests;

public class KeychainTests
{
    [Fact]
    public void Add_ValidEntry_Succeeds()
    {
        var mgr = new KeychainManager();
        var entry = new KeychainEntry("myapp", "user@example.com", "secret123");
        Assert.True(mgr.Add(entry));
    }

    [Fact]
    public void Query_ExistingEntry_ReturnsEntry()
    {
        var mgr = new KeychainManager();
        var entry = new KeychainEntry("myapp", "user", "pass");
        mgr.Add(entry);
        
        var result = mgr.Query("myapp", "user");
        Assert.NotNull(result);
        Assert.Equal("pass", result.Secret);
    }

    [Fact]
    public void Query_NonExistent_ReturnsNull()
    {
        var mgr = new KeychainManager();
        var result = mgr.Query("fake", "user");
        Assert.Null(result);
    }

    [Fact]
    public void Remove_ExistingEntry_Succeeds()
    {
        var mgr = new KeychainManager();
        mgr.Add(new KeychainEntry("svc", "acc", "sec"));
        Assert.True(mgr.Remove("svc", "acc"));
        Assert.Null(mgr.Query("svc", "acc"));
    }
}