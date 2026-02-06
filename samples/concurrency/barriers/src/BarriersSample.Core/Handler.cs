namespace BarriersSample.Core;
public class Handler { public string Process() => "Barriers ready"; }
public class SimpleBarrier {
    private int _arrived = 0;
    private int _expected;
    public SimpleBarrier(int expected) => _expected = expected;
    public bool SignalAndWait() {
        Interlocked.Increment(ref _arrived);
        return _arrived == _expected;
    }
}