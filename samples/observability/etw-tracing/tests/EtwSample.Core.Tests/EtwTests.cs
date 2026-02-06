using Xunit;
using EtwSample.Core;
namespace EtwSample.Core.Tests;
public class EtwTests {
    [Fact] public void LogEvent_Succeeds() {
        var tracer = new EventTracer();
        tracer.LogEvent("test");
        Assert.True(true);
    }
}