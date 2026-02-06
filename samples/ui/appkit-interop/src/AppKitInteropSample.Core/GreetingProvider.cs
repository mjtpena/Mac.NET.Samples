namespace AppKitInteropSample.Core;

public sealed class GreetingProvider
{
    private readonly TimeProvider _timeProvider;

    public GreetingProvider(TimeProvider? timeProvider = null)
    {
        _timeProvider = timeProvider ?? TimeProvider.System;
    }

    public string GetGreeting(string? name)
    {
        var safeName = string.IsNullOrWhiteSpace(name) ? "macOS" : name.Trim();
        return $"Hello {safeName} from AppKit at {_timeProvider.GetUtcNow():O}.";
    }
}
