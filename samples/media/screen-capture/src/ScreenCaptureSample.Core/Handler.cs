namespace ScreenCaptureSample.Core;
public class Handler { public string Process() => "Screen capture ready"; }
public record Screenshot(int Width, int Height, DateTime CaptureTime);
public class ScreenRecorder {
    private List<Screenshot> _captures = new();
    public void CaptureScreen(int w, int h) => _captures.Add(new(w, h, DateTime.Now));
    public int CaptureCount => _captures.Count;
}