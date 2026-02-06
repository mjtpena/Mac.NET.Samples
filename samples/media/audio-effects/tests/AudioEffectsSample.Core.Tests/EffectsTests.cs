using Xunit;
using AudioEffectsSample.Core;
namespace AudioEffectsSample.Core.Tests;
public class EffectsTests {
    [Fact] public void SetIntensity_ClampsValue() {
        var fx = new AudioEffect();
        fx.SetIntensity(1.5f);
        Assert.Equal(1f, fx.GetIntensity());
    }
}