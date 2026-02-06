using Xunit;
using SpotlightSample.Core;
namespace SpotlightSample.Core.Tests;
public class SpotlightTests {
    [Fact] public void IndexFile_IncrementsCount() {
        var idx = new SpotlightIndexer();
        idx.IndexFile("/file.txt");
        Assert.Equal(1, idx.IndexedCount);
    }
}