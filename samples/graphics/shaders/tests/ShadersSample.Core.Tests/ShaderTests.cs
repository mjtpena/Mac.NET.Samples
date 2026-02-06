using Xunit;
using ShadersSample.Core;
namespace ShadersSample.Core.Tests;
public class ShaderTests {
    [Fact] public void CompileVertexShader_ValidCode_Succeeds() {
        var compiler = new ShaderCompiler();
        Assert.True(compiler.CompileVertexShader("void main {}"));
    }
}