namespace MinimalApiSample.Core;

public class Handler { public string Process() => "Minimal API ready"; }

public record Item(int Id, string Name);

public class ItemStore
{
    private readonly Dictionary<int, Item> _items = new();
    private int _nextId = 1;

    public Item Add(string name)
    {
        var item = new Item(_nextId++, name);
        _items[item.Id] = item;
        return item;
    }

    public Item? Get(int id) => _items.TryGetValue(id, out var item) ? item : null;
    public IEnumerable<Item> GetAll() => _items.Values;
    public bool Delete(int id) => _items.Remove(id);
}