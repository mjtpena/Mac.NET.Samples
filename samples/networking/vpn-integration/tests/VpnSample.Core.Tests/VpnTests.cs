using Xunit;
using VpnSample.Core;
namespace VpnSample.Core.Tests;
public class VpnTests {
    [Fact] public void Connect_EstablishesConnection() {
        var vpn = new VpnClient();
        vpn.Connect("vpn.example.com");
        Assert.True(vpn.IsConnected);
    }
}