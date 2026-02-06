using VideoToolboxSample.Core;

Console.WriteLine("[VideoToolbox Sample]");

var frame = new FrameInfo(1920, 1080, 33);
var codec = new VideoCodec { Name = "H.265", BitrateMbps = 25 };

Console.WriteLine(codec.GetCodecInfo(frame));
