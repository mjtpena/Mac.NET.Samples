namespace UsbSample.Core;

/// <summary>
/// USB device management and communication.
/// </summary>
public class Handler
{
    public string Process() => "USB device management ready";
}

public class UsbDevice
{
    public string VendorId { get; set; } = string.Empty;
    public string ProductId { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
}

public class UsbManager
{
    private readonly List<UsbDevice> _devices = new();
    
    public void RegisterDevice(UsbDevice device) => _devices.Add(device);
    
    public IEnumerable<UsbDevice> FindDevicesByVendor(string vendorId) => 
        _devices.Where(d => d.VendorId == vendorId);
    
    public UsbDevice? FindDeviceBySerial(string serial) => 
        _devices.FirstOrDefault(d => d.SerialNumber == serial);
}
