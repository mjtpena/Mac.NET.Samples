using Xunit;
using CoreMlSample.Core;

namespace CoreMlSample.Core.Tests;

public class MLTests
{
    [Fact]
    public void Predict_ReturnsLabel()
    {
        var model = new MLPredictor();
        var pred = model.Predict(new[] { 1f, 0.8f, 0.9f });
        
        Assert.NotEmpty(pred.Label);
        Assert.InRange(pred.Confidence, 0, 1);
    }
}