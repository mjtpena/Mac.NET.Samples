using AppKit;
using Foundation;
using AppKitInteropSample.Core;

namespace AppKitInteropSample;

[Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    private NSWindow? _window;

    public override void DidFinishLaunching(NSNotification notification)
    {
        var greetingProvider = new GreetingProvider();

        var label = new NSTextField
        {
            StringValue = greetingProvider.GetGreeting("AppKit"),
            Bezeled = false,
            DrawsBackground = false,
            Editable = false,
            Selectable = false,
            Alignment = NSTextAlignment.Center,
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        var contentView = new NSView();
        contentView.AddSubview(label);

        _window = new NSWindow(
            new CoreGraphics.CGRect(0, 0, 640, 360),
            NSWindowStyle.Titled | NSWindowStyle.Closable | NSWindowStyle.Resizable,
            NSBackingStore.Buffered,
            false)
        {
            Title = "AppKit Interop Sample",
            ContentView = contentView
        };

        NSLayoutConstraint.ActivateConstraints(new[]
        {
            label.CenterXAnchor.ConstraintEqualToAnchor(contentView.CenterXAnchor),
            label.CenterYAnchor.ConstraintEqualToAnchor(contentView.CenterYAnchor),
            label.LeadingAnchor.ConstraintGreaterThanOrEqualToAnchor(contentView.LeadingAnchor, 24),
            label.TrailingAnchor.ConstraintLessThanOrEqualToAnchor(contentView.TrailingAnchor, -24)
        });

        _window.MakeKeyAndOrderFront(null);
    }
}
