namespace NotificationSample.Core;

public sealed record LocalNotification(string Title, string Body, string? ActionUrl = null)
{
    public bool IsValid() => !string.IsNullOrWhiteSpace(Title) && !string.IsNullOrWhiteSpace(Body);
}

public sealed class NotificationQueue
{
    private readonly Queue<LocalNotification> _queue = new();

    public void Enqueue(LocalNotification notification)
    {
        if (notification.IsValid())
        {
            _queue.Enqueue(notification);
        }
    }

    public LocalNotification? Dequeue() => _queue.Count > 0 ? _queue.Dequeue() : null;
}
