using Xunit;
using OpenGLSample.Core;
namespace OpenGLSample.Core.Tests;
public class GLTests {
    [Fact] public void Initialize_SetsFlag() {
        var ctx = new GLContext(); ctx.Initialize();
        Assert.True(ctx.IsInitialized);
    }
    [Fact] public void Render_ExecutesCallback() {
        var ctx = new GLContext(); ctx.Initialize();
        var called = false; ctx.Render(() => called = true);
        Assert.True(called);
    }
}