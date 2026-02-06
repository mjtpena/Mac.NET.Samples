namespace OtelDtraceSample.Core;

/// <summary>
/// OpenTelemetry and DTrace integration.
/// </summary>
public class Handler
{
    public string Process() => "OpenTelemetry + DTrace initialized";
}

public class Metric
{
    public string Name { get; set; } = string.Empty;
    public double Value { get; set; }
    public Dictionary<string, string> Tags { get; set; } = new();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

public class MetricsCollector
{
    private readonly List<Metric> _metrics = new();
    
    public void RecordMetric(string name, double value, Dictionary<string, string>? tags = null)
    {
        _metrics.Add(new Metric
        {
            Name = name,
            Value = value,
            Tags = tags ?? new(),
        });
    }
    
    public IEnumerable<Metric> GetMetrics(string name) => 
        _metrics.Where(m => m.Name == name);
    
    public double GetAverageValue(string name)
    {
        var values = _metrics.Where(m => m.Name == name).ToList();
        return values.Count > 0 ? values.Average(m => m.Value) : 0;
    }
}
