using Xunit;
using DynCodegenSample.Core;
namespace DynCodegenSample.Core.Tests;
public class CodegenTests {
    [Fact] public void ExecuteAddition_CalculatesResult() {
        var result = DynamicMethod.ExecuteAddition(5, 3);
        Assert.Equal(8, result);
    }
}