using Xunit;
using SimdSample.Core;
namespace SimdSample.Core.Tests;
public class SimdTests {
    [Fact] public void MultiplyArrays_CalculatesCorrectly() {
        var result = SimdOps.MultiplyArrays(new[] {1, 2}, new[] {3, 4});
        Assert.Equal(new[] {3, 8}, result);
    }
}