using Xunit;
using FileSystemWatcherSample.Core;
namespace FileSystemWatcherSample.Core.Tests;
public class FileWatcherTests {
    [Fact] public void LogEvent_RecordsEvent() {
        var monitor = new FileSystemMonitor();
        monitor.LogEvent("/tmp/file.txt", "created");
        Assert.Equal(1, monitor.GetEventCount());
    }
}