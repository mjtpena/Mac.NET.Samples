namespace VideoCaptureSample.Core;
public class Handler { public string Process() => "Video capture ready"; }
public record Frame(int Width, int Height, byte[] Data);
public class VideoCapture {
    private List<Frame> _frames = new();
    public void CaptureFrame(int w, int h) => _frames.Add(new(w, h, new byte[w * h]));
    public int FrameCount => _frames.Count;
}