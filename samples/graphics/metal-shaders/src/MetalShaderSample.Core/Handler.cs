namespace MetalShaderSample.Core;
public class Handler { public string Process() => "Metal shaders ready"; }
public class ShaderLibrary {
    public bool LoadShader(string name) => !string.IsNullOrEmpty(name);
}