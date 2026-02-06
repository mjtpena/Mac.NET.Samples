using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    name = "Minimal API Sample",
    framework = ".NET 10",
    os = "macOS",
    timeUtc = DateTimeOffset.UtcNow
}));

app.MapHealthChecks("/health");

var items = new ConcurrentDictionary<int, Item>(new[]
{
    new KeyValuePair<int, Item>(1, new Item(1, "Starter", "Seed item")),
    new KeyValuePair<int, Item>(2, new Item(2, "Notes", "Hello from macOS"))
});

app.MapGet("/items", () => Results.Ok(items.Values.OrderBy(i => i.Id)));

app.MapGet("/items/{id:int}", (int id) =>
{
    return items.TryGetValue(id, out var item)
        ? Results.Ok(item)
        : Results.NotFound(new { message = "Item not found", id });
});

app.MapPost("/items", (CreateItem request) =>
{
    var nextId = items.Keys.DefaultIfEmpty(0).Max() + 1;
    var item = new Item(nextId, request.Name, request.Description);
    items[nextId] = item;
    return Results.Created($"/items/{nextId}", item);
});

app.MapDelete("/items/{id:int}", (int id) =>
{
    return items.TryRemove(id, out _)
        ? Results.NoContent()
        : Results.NotFound(new { message = "Item not found", id });
});

app.Run();

public sealed record Item(int Id, string Name, string Description);

public sealed record CreateItem(string Name, string Description);

public partial class Program;
