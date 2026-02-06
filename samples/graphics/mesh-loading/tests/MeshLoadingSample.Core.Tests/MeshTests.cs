using Xunit;
using MeshLoadingSample.Core;

namespace MeshLoadingSample.Core.Tests;

public class MeshTests
{
    [Fact]
    public void AddVertex_IncrementsCount()
    {
        var mesh = new Mesh();
        mesh.AddVertex(0, 0, 0);
        mesh.AddVertex(1, 0, 0);
        Assert.Equal(2, mesh.VertexCount);
    }

    [Fact]
    public void AddTriangle_TracksTriangle()
    {
        var mesh = new Mesh();
        mesh.AddVertex(0, 0, 0);
        mesh.AddVertex(1, 0, 0);
        mesh.AddVertex(0, 1, 0);
        mesh.AddTriangle(0, 1, 2);
        Assert.Equal(1, mesh.TriangleCount);
    }
}