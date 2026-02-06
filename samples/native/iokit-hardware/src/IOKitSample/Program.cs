using IOKitSample.Core;

Console.WriteLine("[IOKit Hardware Sample]");

var registry = new HardwareRegistry();
registry.Register(new HardwareDevice("CPU", "Apple M3", "Active"));

foreach (var device in registry.ListAll())
{
    Console.WriteLine($"Device: {device.Name} ({device.ModelIdentifier})");
}
