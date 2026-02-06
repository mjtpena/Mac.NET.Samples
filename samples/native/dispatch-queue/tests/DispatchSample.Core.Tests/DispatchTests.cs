using Xunit;
using DispatchSample.Core;
namespace DispatchSample.Core.Tests;
public class DispatchTests {
    [Fact] public void Enqueue_Then_Flush() {
        var queue = new DispatchQueue();
        var called = false;
        queue.Enqueue(() => called = true);
        queue.Flush();
        Assert.True(called);
    }
}