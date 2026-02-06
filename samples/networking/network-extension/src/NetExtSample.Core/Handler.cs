namespace NetExtSample.Core;
public class Handler { public string Process() => "Network extension ready"; }
public class NetworkExtension {
    public bool IsActive { get; set; }
}