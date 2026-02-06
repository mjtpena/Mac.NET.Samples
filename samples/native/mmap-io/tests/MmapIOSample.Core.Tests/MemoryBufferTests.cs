using MmapIOSample.Core;

namespace MmapIOSample.Core.Tests;

public sealed class MemoryBufferTests
{
    [Fact]
    public void Write_And_Read()
    {
        var buf = new MemoryBuffer(10);
        buf.Write(5, 123);

        Assert.Equal(123, buf.Read(5));
    }
}
