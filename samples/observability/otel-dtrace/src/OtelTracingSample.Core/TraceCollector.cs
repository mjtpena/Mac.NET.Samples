namespace OtelTracingSample.Core;

public sealed record SpanData(string Name, long DurationMs, DateTimeOffset StartTime)
{
    public static SpanData Create(string name, long durationMs)
    {
        return new SpanData(name, durationMs, DateTimeOffset.UtcNow);
    }
}

public sealed class TraceCollector
{
    private readonly List<SpanData> _spans = new();

    public void RecordSpan(SpanData span)
    {
        _spans.Add(span);
    }

    public IReadOnlyList<SpanData> GetSpans() => _spans.AsReadOnly();

    public long GetTotalDuration() => _spans.Sum(s => s.DurationMs);
}
