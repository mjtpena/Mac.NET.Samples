namespace VideoCompSample.Core;
public class Handler { public string Process() => "Video composition ready"; }
public class Compositor {
    public int TrackCount { get; private set; }
    public void AddTrack() => TrackCount++;
}