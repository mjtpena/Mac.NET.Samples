namespace AudioEffectsSample.Core;
public class Handler { public string Process() => "Audio effects ready"; }
public class AudioEffect {
    private float _intensity = 0f;
    public void SetIntensity(float v) => _intensity = Math.Clamp(v, 0, 1);
    public float GetIntensity() => _intensity;
}