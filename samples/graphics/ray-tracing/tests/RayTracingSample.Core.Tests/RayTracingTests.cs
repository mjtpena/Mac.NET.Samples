using Xunit;
using RayTracingSample.Core;
namespace RayTracingSample.Core.Tests;
public class RayTracingTests {
    [Fact] public void DotProduct_CalculatesCorrectly() {
        var a = new Vector3(1, 2, 3); var b = new Vector3(4, 5, 6);
        var result = RayTracer.DotProduct(a, b);
        Assert.Equal(32, result);
    }
}