using Xunit;
using DistributedTracingSample.Core;

namespace DistributedTracingSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("Distributed", handler.Process());
    }
    
    [Fact]
    public void TracingContext_CreatesSpans()
    {
        var ctx = new TracingContext();
        var span = ctx.CreateSpan("op");
        
        Assert.NotNull(span);
        Assert.Equal("op", span.Name);
    }
    
    [Fact]
    public void TracingContext_TracksParentChild()
    {
        var ctx = new TracingContext();
        var parent = ctx.CreateSpan("parent");
        var child = ctx.CreateSpan("child", parent.SpanId);
        
        var children = ctx.GetChildSpans(parent.SpanId).ToList();
        
        Assert.Single(children);
        Assert.Equal(child, children[0]);
    }
}
