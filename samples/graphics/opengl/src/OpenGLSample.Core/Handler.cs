namespace OpenGLSample.Core;
public class Handler { public string Process() => "OpenGL ready"; }
public class GLContext {
    public bool IsInitialized { get; private set; }
    public void Initialize() => IsInitialized = true;
    public void Render(Action onRender) { if (IsInitialized) onRender(); }
}