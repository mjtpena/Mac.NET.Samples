namespace MemLeaksSample.Core;
public class Handler { public string Process() => "Memory leaks ready"; }
public class ResourceManager : IDisposable {
    private bool _disposed = false;
    public void Dispose() => _disposed = true;
}