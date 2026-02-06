using GcdAsyncSample.Core;

Console.WriteLine("[GCD + async Sample]");

var queue = new DispatchQueue();
queue.Enqueue(new DispatchTask { Name = "Task 1" });
queue.Enqueue(new DispatchTask { Name = "Task 2", Priority = 1 });

await queue.ProcessAsync(async task =>
{
    Console.WriteLine($"Processing: {task.Name}");
    await Task.Delay(100);
});

Console.WriteLine("Done");
