using Xunit;
using ScreenCaptureSample.Core;
namespace ScreenCaptureSample.Core.Tests;
public class ScreenCaptureTests {
    [Fact] public void CaptureScreen_RecordsScreenshot() {
        var rec = new ScreenRecorder(); rec.CaptureScreen(1920, 1080);
        Assert.Equal(1, rec.CaptureCount);
    }
}