using Xunit;
using MemoryProfilingSample.Core;
namespace MemoryProfilingSample.Core.Tests;
public class MemoryProfilerTests {
    [Fact] public void TakeSnapshot_RecordsAllocation() {
        var prof = new MemoryProfiler(); prof.TakeSnapshot(); prof.TakeSnapshot();
        var peak = prof.GetPeakAllocation(); Assert.True(peak > 0);
    }
}