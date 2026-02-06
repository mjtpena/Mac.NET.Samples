using Xunit;
using ThreadSafetySample.Core;
namespace ThreadSafetySample.Core.Tests;
public class ThreadSafetyTests {
    [Fact] public void Increment_IsThreadSafe() {
        var counter = new ThreadSafeCounter();
        counter.Increment(); counter.Increment();
        Assert.Equal(2, counter.GetCount());
    }
}