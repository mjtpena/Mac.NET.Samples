namespace WorkerLaunchdSample.Tests;

public sealed class HeartbeatStateTests
{
    [Fact]
    public void Update_Increments_Count()
    {
        var state = new HeartbeatState();
        var now = new DateTimeOffset(2026, 2, 6, 0, 0, 0, TimeSpan.Zero);

        var first = state.Update(now);
        var second = state.Update(now.AddMinutes(1));

        Assert.Equal(2, state.Count);
        Assert.StartsWith("1:", first);
        Assert.StartsWith("2:", second);
    }
}
