using Xunit;
using LockFreeSample.Core;
namespace LockFreeSample.Core.Tests;
public class LockFreeTests {
    [Fact] public void Enqueue_ThenDequeue() {
        var q = new LockFreeQueue<int>();
        q.Enqueue(42);
        Assert.True(q.TryDequeue(out var val));
        Assert.Equal(42, val);
    }
}