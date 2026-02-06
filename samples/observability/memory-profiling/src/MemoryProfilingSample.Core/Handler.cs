namespace MemoryProfilingSample.Core;
public class Handler { public string Process() => "Memory profiling ready"; }
public class MemorySnapshot { public long Timestamp { get; set; } public long AllocatedBytes { get; set; } }
public class MemoryProfiler {
    private readonly List<MemorySnapshot> _snapshots = new();
    public void TakeSnapshot() {
        _snapshots.Add(new() { Timestamp = DateTime.Now.Ticks, AllocatedBytes = GC.GetTotalMemory(false) });
    }
    public long GetPeakAllocation() => _snapshots.MaxBy(s => s.AllocatedBytes)?.AllocatedBytes ?? 0;
}