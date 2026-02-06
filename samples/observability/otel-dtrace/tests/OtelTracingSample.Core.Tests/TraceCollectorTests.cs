using OtelTracingSample.Core;

namespace OtelTracingSample.Core.Tests;

public sealed class TraceCollectorTests
{
    [Fact]
    public void RecordSpan_StoresSpan()
    {
        var collector = new TraceCollector();
        var span = SpanData.Create("test", 100);

        collector.RecordSpan(span);

        Assert.Single(collector.GetSpans());
    }

    [Fact]
    public void GetTotalDuration_SumsAll()
    {
        var collector = new TraceCollector();
        collector.RecordSpan(SpanData.Create("s1", 50));
        collector.RecordSpan(SpanData.Create("s2", 30));

        Assert.Equal(80, collector.GetTotalDuration());
    }
}
