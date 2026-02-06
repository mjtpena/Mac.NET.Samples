namespace BluetoothSample.Core;
public class Handler { public string Process() => "Bluetooth ready"; }
public record BluetoothDevice(string Address, string Name, int Rssi);
public class BluetoothScanner {
    private List<BluetoothDevice> _devices = new();
    public void AddDevice(string addr, string name, int rssi) => _devices.Add(new(addr, name, rssi));
    public int GetDeviceCount() => _devices.Count;
}