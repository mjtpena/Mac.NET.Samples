using ProcessMonitorSample.Core;

namespace ProcessMonitorSample.Core.Tests;

public sealed class ProcessMonitorTests
{
    [Fact]
    public void RecordSnapshot_StoresData()
    {
        var monitor = new ProcessMonitor();
        var snapshot = new ProcessSnapshot(123, "test", 50, 512);

        monitor.RecordSnapshot(snapshot);

        Assert.Single(monitor.GetSnapshots());
    }
}
