namespace OtelSample.Core;
public class Handler { public string Process() => "OpenTelemetry DTrace ready"; }
public class OtelTracer {
    public bool IsEnabled { get; set; }
}