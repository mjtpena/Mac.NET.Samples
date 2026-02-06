using Xunit;
using CoreAudioSample.Core;

namespace CoreAudioSample.Core.Tests;

public class AudioDSPTests
{
    [Fact]
    public void ApplyGain_Clamps()
    {
        var result = AudioDSP.ApplyGain(1f, 2f);
        Assert.Equal(1f, result);
    }

    [Fact]
    public void SimpleLowPass_Filters()
    {
        var result = AudioDSP.SimpleLowPass(1f, 0f, 0.5f);
        Assert.Equal(0.5f, result);
    }
}
