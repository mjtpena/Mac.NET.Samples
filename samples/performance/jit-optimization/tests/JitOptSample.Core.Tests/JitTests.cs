using Xunit;
using JitOptSample.Core;
namespace JitOptSample.Core.Tests;
public class JitTests {
    [Fact] public void TimeExecution_MeasuresTime() {
        var bench = new JitBenchmark();
        var time = bench.TimeExecution(() => { var x = 1 + 1; });
        Assert.True(time >= 0);
    }
}