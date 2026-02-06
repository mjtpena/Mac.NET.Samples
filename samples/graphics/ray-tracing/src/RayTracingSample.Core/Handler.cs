namespace RayTracingSample.Core;
public class Handler { public string Process() => "Ray tracing ready"; }
public record Vector3(float X, float Y, float Z);
public class RayTracer {
    public static float DotProduct(Vector3 a, Vector3 b) => a.X * b.X + a.Y * b.Y + a.Z * b.Z;
}