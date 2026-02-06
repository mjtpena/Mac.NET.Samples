namespace SqliteCustomSample.Core;

public class Handler { public string Process() => "SQLite custom ready"; }

public class SimpleDatabase
{
    private readonly List<(int Id, string Value)> _data = new();

    public void Insert(int id, string value)
    {
        if (!_data.Any(d => d.Id == id))
            _data.Add((id, value));
    }

    public string? Query(int id) => _data.FirstOrDefault(d => d.Id == id).Value;

    public int GetRowCount() => _data.Count;

    public bool Delete(int id) => _data.RemoveAll(d => d.Id == id) > 0;
}