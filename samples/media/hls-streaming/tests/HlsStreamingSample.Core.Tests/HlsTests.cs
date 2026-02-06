using Xunit;
using HlsStreamingSample.Core;
namespace HlsStreamingSample.Core.Tests;
public class HlsTests {
    [Fact] public void AddSegment_RecordsSegment() {
        var player = new HlsPlayer();
        player.AddSegment("seg1.ts", 10);
        Assert.Equal(1, player.SegmentCount);
    }
}