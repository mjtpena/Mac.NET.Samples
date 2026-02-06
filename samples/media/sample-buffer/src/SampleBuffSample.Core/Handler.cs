namespace SampleBuffSample.Core;
public class Handler { public string Process() => "Sample buffer ready"; }
public class AudioBuffer {
    private float[] _samples;
    public AudioBuffer(int size) => _samples = new float[size];
    public int SampleCount => _samples.Length;
}