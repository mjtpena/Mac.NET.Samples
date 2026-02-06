using Xunit;
using OtelSample.Core;
namespace OtelSample.Core.Tests;
public class OtelTests {
    [Fact] public void IsEnabled_CanBeSet() {
        var tracer = new OtelTracer();
        tracer.IsEnabled = true;
        Assert.True(tracer.IsEnabled);
    }
}