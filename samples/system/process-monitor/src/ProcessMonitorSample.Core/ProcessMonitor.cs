namespace ProcessMonitorSample.Core;

public sealed record ProcessSnapshot(int Pid, string Name, int CpuPercent, long MemoryMb);

public sealed class ProcessMonitor
{
    private readonly List<ProcessSnapshot> _snapshots = new();

    public void RecordSnapshot(ProcessSnapshot snapshot)
    {
        _snapshots.Add(snapshot);
    }

    public IReadOnlyList<ProcessSnapshot> GetSnapshots() => _snapshots.AsReadOnly();
}
