using VideoToolboxSample.Core;

namespace VideoToolboxSample.Core.Tests;

public sealed class VideoCodecTests
{
    [Fact]
    public void GetCodecInfo_IncludesDetails()
    {
        var frame = new FrameInfo(1920, 1080, 100);
        var codec = new VideoCodec();

        var info = codec.GetCodecInfo(frame);

        Assert.Contains("1920", info);
        Assert.Contains("1080", info);
    }
}
