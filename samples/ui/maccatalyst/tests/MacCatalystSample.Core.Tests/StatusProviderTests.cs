using MacCatalystSample.Core;

namespace MacCatalystSample.Core.Tests;

public sealed class StatusProviderTests
{
    [Fact]
    public void GetStatus_UsesFallbackName()
    {
        var fixedTime = new DateTimeOffset(2026, 2, 6, 0, 0, 0, TimeSpan.Zero);
        var provider = new StatusProvider(new FixedTimeProvider(fixedTime));

        var result = provider.GetStatus(" ");

        Assert.Contains("macOS", result, StringComparison.OrdinalIgnoreCase);
        Assert.Contains(fixedTime.ToString("O"), result, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void GetStatus_UsesProvidedName()
    {
        var fixedTime = new DateTimeOffset(2026, 2, 6, 0, 0, 0, TimeSpan.Zero);
        var provider = new StatusProvider(new FixedTimeProvider(fixedTime));

        var result = provider.GetStatus("Catalyst");

        Assert.Contains("Catalyst", result, StringComparison.OrdinalIgnoreCase);
    }

    private sealed class FixedTimeProvider(DateTimeOffset fixedTime) : TimeProvider
    {
        public override DateTimeOffset GetUtcNow() => fixedTime;
    }
}
