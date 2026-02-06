namespace MeshLoadingSample.Core;

public class Handler { public string Process() => "Mesh loading ready"; }

public record Vertex(float X, float Y, float Z);
public record Triangle(int V1, int V2, int V3);

public class Mesh
{
    public List<Vertex> Vertices { get; } = new();
    public List<Triangle> Triangles { get; } = new();

    public void AddVertex(float x, float y, float z) => Vertices.Add(new(x, y, z));
    public void AddTriangle(int v1, int v2, int v3) => Triangles.Add(new(v1, v2, v3));
    public int VertexCount => Vertices.Count;
    public int TriangleCount => Triangles.Count;
}