namespace FileSystemWatcherSample.Core;
public class Handler { public string Process() => "File system watcher ready"; }
public record FileEvent(string Path, string EventType, DateTime Timestamp);
public class FileSystemMonitor {
    private List<FileEvent> _events = new();
    public void LogEvent(string path, string type) => _events.Add(new(path, type, DateTime.Now));
    public int GetEventCount() => _events.Count;
}