using Xunit;
using AcidSample.Core;

namespace AcidSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsAcidMessage()
    {
        var handler = new Handler();
        Assert.Contains("ACID", handler.Process());
    }
    
    [Fact]
    public void TransactionManager_TransfersMoneyCorrectly()
    {
        var tm = new TransactionManager();
        tm.CreateAccount("A", 100m);
        tm.CreateAccount("B", 50m);
        
        var success = tm.Transfer("A", "B", 25m);
        
        Assert.True(success);
        Assert.Equal(75m, tm.GetBalance("A"));
        Assert.Equal(75m, tm.GetBalance("B"));
    }
    
    [Fact]
    public void TransactionManager_FailsOnInsufficientFunds()
    {
        var tm = new TransactionManager();
        tm.CreateAccount("A", 10m);
        tm.CreateAccount("B", 50m);
        
        var success = tm.Transfer("A", "B", 50m);
        
        Assert.False(success);
        Assert.Equal(10m, tm.GetBalance("A"));
    }
}
