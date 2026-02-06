namespace EtwSample.Core;
public class Handler { public string Process() => "ETW tracing ready"; }
public class EventTracer {
    public void LogEvent(string evt) { }
}