namespace BonjourSample.Core;
public class Handler { public string Process() => "Bonjour ready"; }
public record ServiceInfo(string Name, string Type, string Host, int Port);
public class ServiceBrowser {
    private List<ServiceInfo> _services = new();
    public void RegisterService(string name, string type, string host, int port) =>
        _services.Add(new(name, type, host, port));
    public List<ServiceInfo> DiscoverServices(string type) => _services.Where(s => s.Type == type).ToList();
}