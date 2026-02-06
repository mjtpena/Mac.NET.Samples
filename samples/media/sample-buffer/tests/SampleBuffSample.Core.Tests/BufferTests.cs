using Xunit;
using SampleBuffSample.Core;
namespace SampleBuffSample.Core.Tests;
public class BufferTests {
    [Fact] public void Constructor_AllocatesSamples() {
        var buf = new AudioBuffer(512);
        Assert.Equal(512, buf.SampleCount);
    }
}