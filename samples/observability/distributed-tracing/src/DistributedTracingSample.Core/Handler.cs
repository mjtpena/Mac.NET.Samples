namespace DistributedTracingSample.Core;

/// <summary>
/// Distributed tracing for microservices.
/// </summary>
public class Handler
{
    public string Process() => "Distributed tracing enabled";
}

public class TraceSpan
{
    public string TraceId { get; set; } = Guid.NewGuid().ToString();
    public string SpanId { get; set; } = Guid.NewGuid().ToString();
    public string? ParentSpanId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    public DateTime? EndTime { get; set; }
}

public class TracingContext
{
    private readonly List<TraceSpan> _spans = new();
    
    public TraceSpan CreateSpan(string name, string? parentSpanId = null)
    {
        var span = new TraceSpan { Name = name, ParentSpanId = parentSpanId };
        _spans.Add(span);
        return span;
    }
    
    public void EndSpan(TraceSpan span) => span.EndTime = DateTime.UtcNow;
    public IEnumerable<TraceSpan> GetChildSpans(string spanId) => 
        _spans.Where(s => s.ParentSpanId == spanId);
}
