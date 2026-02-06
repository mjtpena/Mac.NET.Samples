namespace KernelExtSample.Core;
public class Handler { public string Process() => "Kernel extension ready"; }
public class ExtensionDetector {
    public bool IsSystemExtensionAvailable() => true;
    public string GetOSVersion() => "11.0+";
}