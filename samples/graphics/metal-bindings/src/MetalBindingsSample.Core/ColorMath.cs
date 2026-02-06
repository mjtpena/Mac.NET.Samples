namespace MetalBindingsSample.Core;

public static class ColorMath
{
    public static (float R, float G, float B, float A) ToNormalized(byte r, byte g, byte b, byte a = 255)
    {
        return (r / 255f, g / 255f, b / 255f, a / 255f);
    }

    public static (float R, float G, float B, float A) Blend(
        (float R, float G, float B, float A) colorA,
        (float R, float G, float B, float A) colorB,
        float t)
    {
        var clamped = Math.Clamp(t, 0f, 1f);
        return (
            colorA.R + (colorB.R - colorA.R) * clamped,
            colorA.G + (colorB.G - colorA.G) * clamped,
            colorA.B + (colorB.B - colorA.B) * clamped,
            colorA.A + (colorB.A - colorA.A) * clamped
        );
    }
}
