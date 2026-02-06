namespace NotifSample.Core;
public class Handler { public string Process() => "System notifications ready"; }
public class NotificationCenter {
    private List<string> _notifications = new();
    public void SendNotification(string msg) => _notifications.Add(msg);
    public int NotificationCount => _notifications.Count;
}