using Xunit;
using ImgProcSample.Core;
namespace ImgProcSample.Core.Tests;
public class FilterTests {
    [Fact] public void ApplyBrightness_ScalesValue() {
        var filter = new ImageFilter();
        var result = filter.ApplyBrightness(1.0f, 0.5f);
        Assert.Equal(0.5f, result);
    }
}