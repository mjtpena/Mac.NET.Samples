using KeychainSample.Core;

namespace KeychainSample.Core.Tests;

public sealed class KeychainFormatterTests
{
    [Fact]
    public void FormatDisplay_ReturnsExpectedText()
    {
        var entry = new KeychainEntry("service", "account", "secret");
        var text = KeychainFormatter.FormatDisplay(entry);

        Assert.Contains("service", text, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("account", text, StringComparison.OrdinalIgnoreCase);
    }
}
