namespace UsbSample.Core;
public class Handler { public string Process() => "USB devices ready"; }
public class UsbManager {
    public int DeviceCount { get; private set; }
    public void EnumerateDevices() => DeviceCount = 0;
}