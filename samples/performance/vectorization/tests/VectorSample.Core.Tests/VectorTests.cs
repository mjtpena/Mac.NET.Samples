using Xunit;
using VectorSample.Core;
namespace VectorSample.Core.Tests;
public class VectorTests {
    [Fact] public void AddVectors_CalculatesCorrectly() {
        var result = VectorOps.AddVectors(new[] {1f, 2f}, new[] {3f, 4f});
        Assert.Equal(new[] {4f, 6f}, result);
    }
}