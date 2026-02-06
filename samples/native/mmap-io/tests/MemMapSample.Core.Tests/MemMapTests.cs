using Xunit;
using MemMapSample.Core;
namespace MemMapSample.Core.Tests;
public class MemMapTests {
    [Fact] public void WriteByte_StoresValue() {
        var buf = new MemoryBuffer(100);
        buf.WriteByte(0, 42);
        Assert.Equal(42, buf.ReadByte(0));
    }
}