using Xunit;
using VideoCaptureSample.Core;
namespace VideoCaptureSample.Core.Tests;
public class VideoCaptureTests {
    [Fact] public void CaptureFrame_RecordsFrame() {
        var cap = new VideoCapture(); cap.CaptureFrame(640, 480);
        Assert.Equal(1, cap.FrameCount);
    }
}