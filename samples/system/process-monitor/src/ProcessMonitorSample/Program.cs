using ProcessMonitorSample.Core;

Console.WriteLine("[Process Monitor Sample]");

var monitor = new ProcessMonitor();
monitor.RecordSnapshot(new ProcessSnapshot(1, "kernel_task", 5, 128));
monitor.RecordSnapshot(new ProcessSnapshot(100, "dotnet", 15, 256));

foreach (var snap in monitor.GetSnapshots())
{
    Console.WriteLine($"PID {snap.Pid}: {snap.Name} ({snap.CpuPercent}% CPU, {snap.MemoryMb}MB)");
}
