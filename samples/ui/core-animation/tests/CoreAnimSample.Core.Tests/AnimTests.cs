using Xunit;
using CoreAnimSample.Core;
namespace CoreAnimSample.Core.Tests;
public class AnimTests {
    [Fact] public void Duration_HasDefault() {
        var ctrl = new AnimationController();
        Assert.Equal(0.5f, ctrl.Duration);
    }
}