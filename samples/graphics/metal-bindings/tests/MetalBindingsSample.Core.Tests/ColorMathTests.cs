using MetalBindingsSample.Core;

namespace MetalBindingsSample.Core.Tests;

public sealed class ColorMathTests
{
    [Fact]
    public void ToNormalized_ConvertsToUnitRange()
    {
        var color = ColorMath.ToNormalized(255, 128, 0, 64);

        Assert.Equal(1f, color.R, 3);
        Assert.Equal(0.501f, color.G, 3);
        Assert.Equal(0f, color.B, 3);
        Assert.Equal(0.251f, color.A, 3);
    }

    [Fact]
    public void Blend_InterpolatesColors()
    {
        var start = (0f, 0f, 0f, 1f);
        var end = (1f, 1f, 1f, 1f);

        var mid = ColorMath.Blend(start, end, 0.5f);

        Assert.Equal(0.5f, mid.R, 3);
        Assert.Equal(0.5f, mid.G, 3);
        Assert.Equal(0.5f, mid.B, 3);
        Assert.Equal(1f, mid.A, 3);
    }
}
