namespace ColorSpaceSample.Core;
public class Handler { public string Process() => "Color space ready"; }
public class ColorConverter {
    public static (float, float, float) RgbToHsv(float r, float g, float b) {
        var max = Math.Max(r, Math.Max(g, b));
        return (0, 0, max);
    }
}