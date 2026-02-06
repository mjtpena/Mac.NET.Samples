using OtelTracingSample.Core;

var collector = new TraceCollector();

// Simulate traced operations
var s1 = SpanData.Create("operation-1", 50);
collector.RecordSpan(s1);

var s2 = SpanData.Create("operation-2", 30);
collector.RecordSpan(s2);

var s3 = SpanData.Create("operation-3", 20);
collector.RecordSpan(s3);

Console.WriteLine("[OpenTelemetry + dtrace Sample]");
foreach (var span in collector.GetSpans())
{
    Console.WriteLine($"  Span: {span.Name} ({span.DurationMs}ms) @ {span.StartTime:O}");
}

Console.WriteLine($"Total: {collector.GetTotalDuration()}ms");
Console.WriteLine("[Ready for dtrace integration]");
