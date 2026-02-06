using Xunit;
using DashStreamingSample.Core;
namespace DashStreamingSample.Core.Tests;
public class DashTests {
    [Fact] public void RegisterBitrate_StoresBitrate() {
        var client = new DashClient();
        client.RegisterBitrate(1, 5000);
        Assert.Equal(5000, client.GetBitrate(1));
    }
}