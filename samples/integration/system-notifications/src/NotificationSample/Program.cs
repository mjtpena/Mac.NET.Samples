using NotificationSample.Core;

Console.WriteLine("[System Notifications Sample]");

var queue = new NotificationQueue();
queue.Enqueue(new LocalNotification("Title", "Body"));
queue.Enqueue(new LocalNotification("", "No title")); // skipped

var notif = queue.Dequeue();
if (notif != null)
{
    Console.WriteLine($"Notification: {notif.Title} - {notif.Body}");
}
