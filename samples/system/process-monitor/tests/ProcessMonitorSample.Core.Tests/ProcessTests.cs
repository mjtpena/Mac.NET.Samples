using Xunit;
using ProcessMonitorSample.Core;
namespace ProcessMonitorSample.Core.Tests;
public class ProcessTests {
    [Fact] public void RecordProcess_StoresSnapshot() {
        var mon = new ProcessMonitor(); mon.RecordProcess(100, "test", 1024000);
        var snap = mon.FindProcess(100); Assert.NotNull(snap); Assert.Equal("test", snap.Name);
    }
}