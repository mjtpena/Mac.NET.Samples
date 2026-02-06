using Xunit;
using VideoCompSample.Core;
namespace VideoCompSample.Core.Tests;
public class CompTests {
    [Fact] public void AddTrack_IncrementsCount() {
        var comp = new Compositor();
        comp.AddTrack();
        Assert.Equal(1, comp.TrackCount);
    }
}