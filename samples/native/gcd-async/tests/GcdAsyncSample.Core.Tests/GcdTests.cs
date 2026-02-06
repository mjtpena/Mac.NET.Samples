using Xunit;
using GcdAsyncSample.Core;
namespace GcdAsyncSample.Core.Tests;
public class GcdTests {
    [Fact] public async Task DispatchAsync_ExecutesWork() {
        var disp = new AsyncDispatcher();
        var executed = false;
        await disp.DispatchAsync(async () => { executed = true; await Task.CompletedTask; });
        Assert.True(executed);
    }
}