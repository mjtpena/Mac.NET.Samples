using Xunit;
using CpuProfSample.Core;
namespace CpuProfSample.Core.Tests;
public class CpuProfTests {
    [Fact] public void MeasureTime_ReturnsTime() {
        var prof = new CpuProfiler();
        var time = prof.MeasureTime(() => { });
        Assert.True(time >= 0);
    }
}