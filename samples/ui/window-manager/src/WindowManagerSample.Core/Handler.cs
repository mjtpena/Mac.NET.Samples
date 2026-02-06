namespace WindowManagerSample.Core;
public class Handler { public string Process() => "Window manager ready"; }
public record Window(int Id, string Title, int X, int Y, int Width, int Height);
public class WindowManager {
    private Dictionary<int, Window> _windows = new();
    private int _nextId = 1;
    public int CreateWindow(string title) {
        var id = _nextId++;
        _windows[id] = new(id, title, 0, 0, 800, 600);
        return id;
    }
    public Window? GetWindow(int id) => _windows.TryGetValue(id, out var w) ? w : null;
}