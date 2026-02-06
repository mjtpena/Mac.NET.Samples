namespace NetIOSample.Core;
public class Handler { public string Process() => "Network IO ready"; }
public class NetworkIO {
    public bool IsInitialized { get; private set; }
    public void Initialize() => IsInitialized = true;
}