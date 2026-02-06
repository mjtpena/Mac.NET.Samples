namespace SimdOpsSample.Core;

public class Handler { public string Process() => "SIMD operations ready"; }

public static class SimdMath
{
    public static void MultiplyArrays(float[] a, float[] b, float[] result)
    {
        for (int i = 0; i < a.Length; i++)
            result[i] = a[i] * b[i];
    }

    public static float SumArray(float[] arr) => arr.Sum();
}