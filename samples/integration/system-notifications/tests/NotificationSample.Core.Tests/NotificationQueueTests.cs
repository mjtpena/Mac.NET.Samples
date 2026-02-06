using NotificationSample.Core;

namespace NotificationSample.Core.Tests;

public sealed class NotificationQueueTests
{
    [Fact]
    public void Enqueue_ValidNotification()
    {
        var queue = new NotificationQueue();
        var notif = new LocalNotification("T", "B");

        queue.Enqueue(notif);
        var dequeued = queue.Dequeue();

        Assert.NotNull(dequeued);
        Assert.Equal("T", dequeued.Title);
    }

    [Fact]
    public void Enqueue_SkipsInvalid()
    {
        var queue = new NotificationQueue();
        queue.Enqueue(new LocalNotification("", ""));

        var dequeued = queue.Dequeue();

        Assert.Null(dequeued);
    }
}
