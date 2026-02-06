namespace CoreAudioSample.Core;

public class Handler { public string Process() => "Core Audio ready"; }

public static class AudioDSP
{
    public static float ApplyGain(float sample, float gain)
    {
        var result = sample * gain;
        return Math.Clamp(result, -1f, 1f);
    }

    public static float SimpleLowPass(float current, float previous, float alpha)
    {
        return alpha * current + (1 - alpha) * previous;
    }
}