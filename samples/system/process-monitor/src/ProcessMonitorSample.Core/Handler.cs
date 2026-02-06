namespace ProcessMonitorSample.Core;
public class Handler { public string Process() => "Process monitor ready"; }
public record ProcessSnapshot(int Pid, string Name, long MemoryBytes, DateTime CapturedAt);
public class ProcessMonitor {
    private readonly List<ProcessSnapshot> _snapshots = new();
    public void RecordProcess(int pid, string name, long mem) => _snapshots.Add(new(pid, name, mem, DateTime.Now));
    public ProcessSnapshot? FindProcess(int pid) => _snapshots.FirstOrDefault(p => p.Pid == pid);
}