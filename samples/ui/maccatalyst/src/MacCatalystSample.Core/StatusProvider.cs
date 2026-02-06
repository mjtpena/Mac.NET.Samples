namespace MacCatalystSample.Core;

public sealed class StatusProvider
{
    private readonly TimeProvider _timeProvider;

    public StatusProvider(TimeProvider? timeProvider = null)
    {
        _timeProvider = timeProvider ?? TimeProvider.System;
    }

    public string GetStatus(string userName)
    {
        var name = string.IsNullOrWhiteSpace(userName) ? "macOS" : userName.Trim();
        return $"Hello {name} from .NET 10 ({_timeProvider.GetUtcNow():O}).";
    }
}
