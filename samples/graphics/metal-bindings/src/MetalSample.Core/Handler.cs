namespace MetalSample.Core;
public class Handler { public string Process() => "Metal bindings ready"; }
public class MetalDevice {
    public bool IsAvailable { get; } = true;
    public string Name => "Metal Device";
}