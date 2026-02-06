namespace ThreadSafetySample.Core;
public class Handler { public string Process() => "Thread safety ready"; }
public class ThreadSafeCounter {
    private int _count = 0;
    public void Increment() => Interlocked.Increment(ref _count);
    public int GetCount() => _count;
}