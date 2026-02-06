namespace SpotlightSample.Core;

public sealed record SearchResult(string Title, string Path, int Relevance);

public sealed class SpotlightSearcher
{
    private readonly List<SearchResult> _index = new();

    public void Index(SearchResult result)
    {
        _index.Add(result);
    }

    public IReadOnlyList<SearchResult> Search(string query)
    {
        return _index
            .Where(r => r.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(r => r.Relevance)
            .ToList();
    }
}
