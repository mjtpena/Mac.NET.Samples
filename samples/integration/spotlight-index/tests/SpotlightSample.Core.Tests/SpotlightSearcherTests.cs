using SpotlightSample.Core;

namespace SpotlightSample.Core.Tests;

public sealed class SpotlightSearcherTests
{
    [Fact]
    public void Search_FindsMatches()
    {
        var searcher = new SpotlightSearcher();
        searcher.Index(new SearchResult("Test", "/tmp/1", 50));

        var results = searcher.Search("test");

        Assert.Single(results);
    }
}
