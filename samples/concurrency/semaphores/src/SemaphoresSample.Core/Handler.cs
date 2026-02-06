namespace SemaphoresSample.Core;

/// <summary>
/// Semaphore synchronization for resource pooling.
/// </summary>
public class Handler
{
    public string Process() => "Semaphore synchronization ready";
}

public class ResourcePool<T> where T : notnull
{
    private readonly Semaphore _semaphore;
    private readonly Queue<T> _resources;
    
    public ResourcePool(IEnumerable<T> resources)
    {
        _resources = new Queue<T>(resources);
        _semaphore = new Semaphore(_resources.Count, _resources.Count);
    }
    
    public T AcquireResource()
    {
        _semaphore.WaitOne();
        lock (_resources)
        {
            return _resources.Dequeue();
        }
    }
    
    public void ReleaseResource(T resource)
    {
        lock (_resources)
        {
            _resources.Enqueue(resource);
        }
        _semaphore.Release();
    }
}
