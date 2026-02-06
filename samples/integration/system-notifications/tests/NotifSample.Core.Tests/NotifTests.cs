using Xunit;
using NotifSample.Core;
namespace NotifSample.Core.Tests;
public class NotifTests {
    [Fact] public void SendNotification_Records() {
        var nc = new NotificationCenter();
        nc.SendNotification("alert");
        Assert.Equal(1, nc.NotificationCount);
    }
}