using Xunit;
using WindowManagerSample.Core;
namespace WindowManagerSample.Core.Tests;
public class WindowTests {
    [Fact] public void CreateWindow_ReturnsWindow() {
        var mgr = new WindowManager();
        var id = mgr.CreateWindow("Main");
        var win = mgr.GetWindow(id);
        Assert.NotNull(win);
        Assert.Equal("Main", win.Title);
    }
}