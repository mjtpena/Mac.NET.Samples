namespace ShadersSample.Core;
public class Handler { public string Process() => "Shaders ready"; }
public class ShaderCompiler {
    public bool CompileVertexShader(string code) => code.Contains("void main");
    public bool CompileFragmentShader(string code) => code.Contains("void main");
}