namespace IOKitSample.Core;

public sealed record HardwareDevice(string Name, string ModelIdentifier, string Status);

public sealed class HardwareRegistry
{
    private readonly List<HardwareDevice> _devices = new();

    public void Register(HardwareDevice device)
    {
        _devices.Add(device);
    }

    public IReadOnlyList<HardwareDevice> ListAll() => _devices.AsReadOnly();
}
