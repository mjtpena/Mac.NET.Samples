using Xunit;
using OtelDtraceSample.Core;

namespace OtelDtraceSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("OpenTelemetry", handler.Process());
    }
    
    [Fact]
    public void MetricsCollector_RecordsMetrics()
    {
        var collector = new MetricsCollector();
        
        collector.RecordMetric("requests", 100);
        collector.RecordMetric("requests", 150);
        
        var metrics = collector.GetMetrics("requests").ToList();
        Assert.Equal(2, metrics.Count);
    }
    
    [Fact]
    public void MetricsCollector_CalculatesAverage()
    {
        var collector = new MetricsCollector();
        
        collector.RecordMetric("latency", 10);
        collector.RecordMetric("latency", 20);
        collector.RecordMetric("latency", 30);
        
        var avg = collector.GetAverageValue("latency");
        Assert.Equal(20, avg);
    }
}
