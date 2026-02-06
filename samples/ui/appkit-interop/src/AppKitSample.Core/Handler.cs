namespace AppKitSample.Core;
public class Handler { public string Process() => "AppKit interop ready"; }
public class AppKitBridge {
    public string GetSystemAppearance() => "light";
}