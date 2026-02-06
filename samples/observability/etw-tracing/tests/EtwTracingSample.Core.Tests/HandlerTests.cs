using Xunit;
using EtwTracingSample.Core;

namespace EtwTracingSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("ETW", handler.Process());
    }
    
    [Fact]
    public void EventTracer_LogsEvents()
    {
        var tracer = new EventTracer();
        tracer.LogEvent("MyEvent", 1, "Test message");
        
        var events = tracer.GetEvents().ToList();
        Assert.Single(events);
    }
    
    [Fact]
    public void EventTracer_FiltersByName()
    {
        var tracer = new EventTracer();
        tracer.LogEvent("Event1", 1, "Msg1");
        tracer.LogEvent("Event2", 2, "Msg2");
        
        var filtered = tracer.GetEventsByName("Event1").ToList();
        Assert.Single(filtered);
    }
}
