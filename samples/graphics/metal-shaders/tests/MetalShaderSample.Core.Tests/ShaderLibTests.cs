using Xunit;
using MetalShaderSample.Core;
namespace MetalShaderSample.Core.Tests;
public class ShaderLibTests {
    [Fact] public void LoadShader_WithName() {
        var lib = new ShaderLibrary();
        Assert.True(lib.LoadShader("vertex_main"));
    }
}