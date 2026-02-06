using AppKit;
using Foundation;
using Metal;
using MetalKit;
using MetalBindingsSample.Core;

namespace MetalBindingsSample;

[Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    private NSWindow? _window;
    private IMTLDevice? _device;
    private IMTLCommandQueue? _commandQueue;

    public override void DidFinishLaunching(NSNotification notification)
    {
        _device = MTLDevice.SystemDefault;
        if (_device is null)
        {
            return;
        }

        _commandQueue = _device.CreateCommandQueue();

        var view = new MTKView(new CoreGraphics.CGRect(0, 0, 720, 480), _device)
        {
            ClearColor = new MTLClearColor(0.1, 0.1, 0.15, 1.0),
            ColorPixelFormat = MTLPixelFormat.BGRA8Unorm,
            PreferredFramesPerSecond = 60,
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        var label = new NSTextField
        {
            StringValue = "Metal bindings: clear color via MTKView",
            Bezeled = false,
            DrawsBackground = false,
            Editable = false,
            Selectable = false,
            Alignment = NSTextAlignment.Center,
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        var contentView = new NSView();
        contentView.AddSubview(view);
        contentView.AddSubview(label);

        NSLayoutConstraint.ActivateConstraints(new[]
        {
            view.TopAnchor.ConstraintEqualToAnchor(contentView.TopAnchor),
            view.BottomAnchor.ConstraintEqualToAnchor(contentView.BottomAnchor),
            view.LeadingAnchor.ConstraintEqualToAnchor(contentView.LeadingAnchor),
            view.TrailingAnchor.ConstraintEqualToAnchor(contentView.TrailingAnchor),
            label.CenterXAnchor.ConstraintEqualToAnchor(contentView.CenterXAnchor),
            label.BottomAnchor.ConstraintEqualToAnchor(contentView.BottomAnchor, -24)
        });

        view.Delegate = new ClearColorRenderer(_device, _commandQueue);

        _window = new NSWindow(
            new CoreGraphics.CGRect(0, 0, 720, 480),
            NSWindowStyle.Titled | NSWindowStyle.Closable | NSWindowStyle.Resizable,
            NSBackingStore.Buffered,
            false)
        {
            Title = "Metal Bindings Sample",
            ContentView = contentView
        };

        _window.MakeKeyAndOrderFront(null);
    }

    private sealed class ClearColorRenderer(IMTLDevice device, IMTLCommandQueue commandQueue) : MTKViewDelegate
    {
        private readonly IMTLDevice _device = device;
        private readonly IMTLCommandQueue _commandQueue = commandQueue;

        public override void Draw(MTKView view)
        {
            if (view.CurrentDrawable is null || view.CurrentRenderPassDescriptor is null)
            {
                return;
            }

            var passDescriptor = view.CurrentRenderPassDescriptor;
            var commandBuffer = _commandQueue.CommandBuffer();
            var encoder = commandBuffer.CreateRenderCommandEncoder(passDescriptor);
            encoder.EndEncoding();
            commandBuffer.PresentDrawable(view.CurrentDrawable);
            commandBuffer.Commit();
        }

        public override void MtkView(MTKView view, CoreGraphics.CGSize drawableSize)
        {
            var start = ColorMath.ToNormalized(26, 26, 38);
            var end = ColorMath.ToNormalized(64, 120, 255);
            var blended = ColorMath.Blend(start, end, 0.25f);
            view.ClearColor = new MTLClearColor(blended.R, blended.G, blended.B, blended.A);
        }
    }
}
