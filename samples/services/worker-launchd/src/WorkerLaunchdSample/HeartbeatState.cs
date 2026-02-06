namespace WorkerLaunchdSample;

public sealed class HeartbeatState
{
    private long _count;

    public long Count => Interlocked.Read(ref _count);

    public string Update(DateTimeOffset now)
    {
        var current = Interlocked.Increment(ref _count);
        return $"{current}:{now:O}";
    }
}
