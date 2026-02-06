namespace LockFreeSample.Core;
public class Handler { public string Process() => "Lock-free collections ready"; }
public class LockFreeQueue<T> {
    private System.Collections.Concurrent.ConcurrentQueue<T> _queue = new();
    public void Enqueue(T item) => _queue.Enqueue(item);
    public bool TryDequeue(out T? item) => _queue.TryDequeue(out item);
}