namespace VectorSample.Core;
public class Handler { public string Process() => "Vectorization ready"; }
public class VectorOps {
    public static float[] AddVectors(float[] a, float[] b) =>
        a.Zip(b, (x, y) => x + y).ToArray();
}