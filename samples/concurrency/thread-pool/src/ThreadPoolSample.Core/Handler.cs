namespace ThreadPoolSample.Core;

/// <summary>
/// Thread pool work scheduling and management.
/// </summary>
public class Handler
{
    public string Process() => "Thread pool management initialized";
}

public class SimpleThreadPool : IDisposable
{
    private readonly Queue<Func<Task>> _workItems = new();
    private readonly int _threadCount;
    private readonly List<Thread> _threads = new();
    private bool _shutdown;
    private readonly object _lockObj = new();
    
    public SimpleThreadPool(int threadCount = 2)
    {
        _threadCount = threadCount;
        Initialize();
    }
    
    private void Initialize()
    {
        for (int i = 0; i < _threadCount; i++)
        {
            var thread = new Thread(WorkerLoop) { IsBackground = true };
            thread.Start();
            _threads.Add(thread);
        }
    }
    
    public void QueueWorkItem(Func<Task> workItem)
    {
        lock (_lockObj)
        {
            if (_shutdown)
                throw new ObjectDisposedException("ThreadPool");
            _workItems.Enqueue(workItem);
            Monitor.Pulse(_lockObj);
        }
    }
    
    private void WorkerLoop()
    {
        while (true)
        {
            Func<Task>? work = null;
            lock (_lockObj)
            {
                while (_workItems.Count == 0 && !_shutdown)
                    Monitor.Wait(_lockObj);
                if (_shutdown && _workItems.Count == 0)
                    break;
                if (_workItems.Count > 0)
                    work = _workItems.Dequeue();
            }
            
            if (work != null)
                work().Wait();
        }
    }
    
    public void Dispose()
    {
        lock (_lockObj)
        {
            _shutdown = true;
            Monitor.PulseAll(_lockObj);
        }
        foreach (var thread in _threads)
            thread.Join(5000);
    }
}
