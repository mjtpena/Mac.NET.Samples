using Xunit;
using AudioRoutingSample.Core;
namespace AudioRoutingSample.Core.Tests;
public class AudioRoutingTests {
    [Fact] public void SetRoute_StoresRoute() {
        var router = new AudioRouter();
        router.SetRoute("mic", "speaker");
        Assert.Equal("speaker", router.GetRoute("mic"));
    }
}