using AppKit;
using Foundation;

namespace MetalBindingsSample;

public static class Program
{
    public static void Main(string[] args)
    {
        NSApplication.Init();
        var app = NSApplication.SharedApplication;
        app.Delegate = new AppDelegate();
        app.Run();
    }
}

public partial class ProgramMarker;
