namespace EtwTracingSample.Core;

/// <summary>
/// ETW (Event Tracing for Windows) event handling.
/// </summary>
public class Handler
{
    public string Process() => "ETW tracing initialized";
}

public class EventTracer
{
    private readonly List<TraceEvent> _events = new();
    
    public void LogEvent(string eventName, int eventId, string message)
    {
        _events.Add(new TraceEvent
        {
            Name = eventName,
            EventId = eventId,
            Message = message,
            Timestamp = DateTime.UtcNow,
        });
    }
    
    public IEnumerable<TraceEvent> GetEvents() => _events.AsReadOnly();
    public IEnumerable<TraceEvent> GetEventsByName(string name) => 
        _events.Where(e => e.Name == name);
}

public record TraceEvent
{
    public string Name { get; set; } = string.Empty;
    public int EventId { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}
