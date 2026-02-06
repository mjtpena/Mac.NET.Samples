namespace HlsStreamingSample.Core;
public class Handler { public string Process() => "HLS streaming ready"; }
public record Segment(string Url, int DurationSec);
public class HlsPlayer {
    private List<Segment> _segments = new();
    public void AddSegment(string url, int dur) => _segments.Add(new(url, dur));
    public int SegmentCount => _segments.Count;
}