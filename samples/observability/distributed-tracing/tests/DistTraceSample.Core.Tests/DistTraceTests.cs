using Xunit;
using DistTraceSample.Core;
namespace DistTraceSample.Core.Tests;
public class DistTraceTests {
    [Fact] public void TraceId_IsGenerated() {
        var ctx = new TraceContext();
        Assert.NotNull(ctx.TraceId);
    }
}