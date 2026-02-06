namespace DistTraceSample.Core;
public class Handler { public string Process() => "Distributed tracing ready"; }
public class TraceContext {
    public string TraceId { get; set; } = Guid.NewGuid().ToString();
}