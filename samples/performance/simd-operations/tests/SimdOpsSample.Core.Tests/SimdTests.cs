using Xunit;
using SimdOpsSample.Core;

namespace SimdOpsSample.Core.Tests;

public class SimdTests
{
    [Fact]
    public void MultiplyArrays_ComputesCorrectly()
    {
        var a = new[] { 1f, 2f, 3f };
        var b = new[] { 2f, 3f, 4f };
        var result = new float[3];
        
        SimdMath.MultiplyArrays(a, b, result);
        
        Assert.Equal(2f, result[0]);
        Assert.Equal(6f, result[1]);
        Assert.Equal(12f, result[2]);
    }
}