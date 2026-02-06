using Xunit;
using WebDriverSample.Core;
namespace WebDriverSample.Core.Tests;
public class WebDriverTests {
    [Fact] public void Navigate_UpdatesUrl() {
        var driver = new WebDriver();
        driver.Navigate("https://example.com");
        Assert.Equal("https://example.com", driver.CurrentUrl);
    }
}