namespace ImgProcSample.Core;
public class Handler { public string Process() => "Image processing ready"; }
public class ImageFilter {
    public float ApplyBrightness(float val, float factor) => val * factor;
}