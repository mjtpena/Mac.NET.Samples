namespace VideoToolboxSample.Core;

public sealed record FrameInfo(int Width, int Height, long TimestampMs);

public sealed class VideoCodec
{
    public string Name { get; set; } = "H.264";

    public int BitrateMbps { get; set; } = 10;

    public string GetCodecInfo(FrameInfo frame)
    {
        return $"{Name} @ {frame.Width}x{frame.Height} {BitrateMbps}Mbps @ {frame.TimestampMs}ms";
    }
}
