namespace SimdSample.Core;
public class Handler { public string Process() => "SIMD intrinsics ready"; }
public class SimdOps {
    public static int[] MultiplyArrays(int[] a, int[] b) =>
        a.Zip(b, (x, y) => x * y).ToArray();
}