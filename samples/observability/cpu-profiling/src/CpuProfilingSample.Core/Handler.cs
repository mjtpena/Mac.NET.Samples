namespace CpuProfilingSample.Core;

/// <summary>
/// CPU profiling for performance analysis.
/// </summary>
public class Handler
{
    public string Process() => "CPU profiling ready";
}

public class CpuProfiler
{
    private readonly Dictionary<string, (TimeSpan duration, int calls)> _measurements = new();
    
    public IDisposable MeasureOperation(string name) => 
        new OperationMeasurement(name, this);
    
    private class OperationMeasurement : IDisposable
    {
        private readonly string _name;
        private readonly CpuProfiler _profiler;
        private readonly DateTime _start;
        
        public OperationMeasurement(string name, CpuProfiler profiler)
        {
            _name = name;
            _profiler = profiler;
            _start = DateTime.UtcNow;
        }
        
        public void Dispose()
        {
            var duration = DateTime.UtcNow - _start;
            if (_profiler._measurements.TryGetValue(_name, out var existing))
                _profiler._measurements[_name] = (existing.duration + duration, existing.calls + 1);
            else
                _profiler._measurements[_name] = (duration, 1);
        }
    }
    
    public TimeSpan GetTotalTime(string name) => 
        _measurements.TryGetValue(name, out var m) ? m.duration : TimeSpan.Zero;
    
    public int GetCallCount(string name) => 
        _measurements.TryGetValue(name, out var m) ? m.calls : 0;
}
