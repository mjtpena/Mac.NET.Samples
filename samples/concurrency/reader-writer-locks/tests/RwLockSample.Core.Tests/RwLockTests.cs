using Xunit;
using RwLockSample.Core;
namespace RwLockSample.Core.Tests;
public class RwLockTests {
    [Fact] public void ReadLock_ExecutesAction() {
        var rwl = new RwLock();
        var called = false;
        rwl.ReadLock(() => called = true);
        Assert.True(called);
    }
}