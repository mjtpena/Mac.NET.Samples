using AppKitInteropSample.Core;

namespace AppKitInteropSample.Core.Tests;

public sealed class GreetingProviderTests
{
    [Fact]
    public void GetGreeting_UsesFallbackName()
    {
        var fixedTime = new DateTimeOffset(2026, 2, 6, 0, 0, 0, TimeSpan.Zero);
        var provider = new GreetingProvider(new FixedTimeProvider(fixedTime));

        var result = provider.GetGreeting(" ");

        Assert.Contains("macOS", result, StringComparison.OrdinalIgnoreCase);
        Assert.Contains(fixedTime.ToString("O"), result, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void GetGreeting_UsesProvidedName()
    {
        var provider = new GreetingProvider(new FixedTimeProvider(new DateTimeOffset(2026, 2, 6, 0, 0, 0, TimeSpan.Zero)));

        var result = provider.GetGreeting("AppKit");

        Assert.Contains("AppKit", result, StringComparison.OrdinalIgnoreCase);
    }

    private sealed class FixedTimeProvider(DateTimeOffset fixedTime) : TimeProvider
    {
        public override DateTimeOffset GetUtcNow() => fixedTime;
    }
}
