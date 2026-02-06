using Xunit;
using BenchmarkingSample.Core;
namespace BenchmarkingSample.Core.Tests;
public class BenchmarkTests {
    [Fact] public void Run_MeasuresTime() {
        var bench = new SimpleBenchmark();
        var result = bench.Run("test", () => Thread.Sleep(10));
        Assert.True(result.ElapsedMs >= 10);
    }
}