namespace AudioRoutingSample.Core;
public class Handler { public string Process() => "Audio routing ready"; }
public class AudioRouter {
    private Dictionary<string, string> _routes = new();
    public void SetRoute(string source, string destination) => _routes[source] = destination;
    public string? GetRoute(string source) => _routes.TryGetValue(source, out var d) ? d : null;
}