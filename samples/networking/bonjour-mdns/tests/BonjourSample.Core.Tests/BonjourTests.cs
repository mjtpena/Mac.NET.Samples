using Xunit;
using BonjourSample.Core;
namespace BonjourSample.Core.Tests;
public class BonjourTests {
    [Fact] public void DiscoverServices_FindsRegistered() {
        var browser = new ServiceBrowser();
        browser.RegisterService("MyApp", "_http._tcp", "localhost", 8080);
        var found = browser.DiscoverServices("_http._tcp");
        Assert.Single(found);
    }
}