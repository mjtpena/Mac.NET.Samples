using Xunit;
using SemaphoresSample.Core;

namespace SemaphoresSample.Core.Tests;

public class SemaphoreTests
{
    [Fact]
    public async Task Acquire_WithAvailableSlots_Succeeds()
    {
        var pool = new SemaphorePool(2);
        var result = await pool.TryAcquireAsync();
        Assert.True(result);
        Assert.Equal(1, pool.AvailableSlots);
    }

    [Fact]
    public async Task Acquire_WhenExhausted_TimeoutFails()
    {
        var pool = new SemaphorePool(1);
        await pool.TryAcquireAsync();
        var result = await pool.TryAcquireAsync(10);
        Assert.False(result);
    }
}