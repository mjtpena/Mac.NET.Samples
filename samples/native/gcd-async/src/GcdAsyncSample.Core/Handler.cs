namespace GcdAsyncSample.Core;
public class Handler { public string Process() => "GCD async ready"; }
public class AsyncDispatcher {
    public async Task DispatchAsync(Func<Task> work) => await work();
}