namespace CoreAudioSample.Core;

public sealed class AudioDSP
{
    public static float ApplyGain(float sample, float gain)
    {
        return Math.Clamp(sample * gain, -1f, 1f);
    }

    public static float SimpleLowPass(float current, float previous, float alpha)
    {
        return alpha * current + (1 - alpha) * previous;
    }
}
