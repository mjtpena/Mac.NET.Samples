namespace GcdAsyncSample.Core;

public sealed class DispatchTask
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public int Priority { get; set; } = 0; // 0 = default, 1 = high
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public sealed class DispatchQueue
{
    private readonly Queue<DispatchTask> _tasks = new();

    public void Enqueue(DispatchTask task)
    {
        _tasks.Enqueue(task);
    }

    public async Task ProcessAsync(Func<DispatchTask, Task> handler)
    {
        while (_tasks.TryDequeue(out var task))
        {
            await handler(task);
        }
    }
}
