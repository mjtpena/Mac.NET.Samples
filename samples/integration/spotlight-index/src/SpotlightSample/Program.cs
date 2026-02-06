using SpotlightSample.Core;

Console.WriteLine("[Spotlight Indexing Sample]");

var searcher = new SpotlightSearcher();
searcher.Index(new SearchResult("Document A", "/tmp/a", 100));
searcher.Index(new SearchResult("Document B", "/tmp/b", 50));

var results = searcher.Search("document");
Console.WriteLine($"Found: {results.Count}");
