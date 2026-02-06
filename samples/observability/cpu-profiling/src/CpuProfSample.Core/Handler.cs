namespace CpuProfSample.Core;
public class Handler { public string Process() => "CPU profiling ready"; }
public class CpuProfiler {
    public long MeasureTime(Action action) {
        var sw = System.Diagnostics.Stopwatch.StartNew();
        action();
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}