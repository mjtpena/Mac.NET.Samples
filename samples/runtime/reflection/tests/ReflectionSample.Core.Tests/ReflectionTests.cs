using Xunit;
using ReflectionSample.Core;

namespace ReflectionSample.Core.Tests;

public class ReflectionTests
{
    private class TestClass { public string Name { get; set; } = string.Empty; }

    [Fact]
    public void GetTypeName_ReturnsCorrectName()
    {
        var insp = new TypeInspector();
        var result = insp.GetTypeName(new TestClass());
        Assert.Equal("TestClass", result);
    }

    [Fact]
    public void GetProperties_ReturnsProperties()
    {
        var insp = new TypeInspector();
        var props = insp.GetProperties<TestClass>();
        Assert.Contains("Name", props);
    }
}