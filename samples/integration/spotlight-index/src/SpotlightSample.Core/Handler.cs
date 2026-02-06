namespace SpotlightSample.Core;
public class Handler { public string Process() => "Spotlight index ready"; }
public class SpotlightIndexer {
    public int IndexedCount { get; private set; }
    public void IndexFile(string path) => IndexedCount++;
}