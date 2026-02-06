using Xunit;
using BarriersSample.Core;
namespace BarriersSample.Core.Tests;
public class BarrierTests {
    [Fact] public void SignalAndWait_ReleasesWhenReady() {
        var barrier = new SimpleBarrier(1);
        Assert.True(barrier.SignalAndWait());
    }
}