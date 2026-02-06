using Foundation;
using UIKit;
using MacCatalystSample.Core;

namespace MacCatalystSample;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    private UIWindow? _window;

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        _window = new UIWindow(UIScreen.MainScreen.Bounds);

        var statusProvider = new StatusProvider();
        var label = new UILabel
        {
            Text = statusProvider.GetStatus("Mac Catalyst"),
            Lines = 0,
            TextAlignment = UITextAlignment.Center,
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        var viewController = new UIViewController();
        viewController.View!.BackgroundColor = UIColor.SystemBackground;
        viewController.View.AddSubview(label);

        NSLayoutConstraint.ActivateConstraints(new[]
        {
            label.CenterXAnchor.ConstraintEqualTo(viewController.View.CenterXAnchor),
            label.CenterYAnchor.ConstraintEqualTo(viewController.View.CenterYAnchor),
            label.LeadingAnchor.ConstraintGreaterThanOrEqualTo(viewController.View.LeadingAnchor, 24),
            label.TrailingAnchor.ConstraintLessThanOrEqualTo(viewController.View.TrailingAnchor, -24)
        });

        _window.RootViewController = viewController;
        _window.MakeKeyAndVisible();

        return true;
    }
}
