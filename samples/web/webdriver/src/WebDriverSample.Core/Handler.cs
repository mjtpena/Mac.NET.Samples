namespace WebDriverSample.Core;
public class Handler { public string Process() => "WebDriver ready"; }
public class WebDriver {
    public string CurrentUrl { get; set; } = "";
    public void Navigate(string url) => CurrentUrl = url;
    public string? FindElement(string selector) => selector == "id=main" ? "main-element" : null;
}