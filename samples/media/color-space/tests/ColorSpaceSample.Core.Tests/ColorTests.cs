using Xunit;
using ColorSpaceSample.Core;
namespace ColorSpaceSample.Core.Tests;
public class ColorTests {
    [Fact] public void RgbToHsv_ReturnsValue() {
        var (h, s, v) = ColorConverter.RgbToHsv(1, 1, 1);
        Assert.Equal(1, v);
    }
}