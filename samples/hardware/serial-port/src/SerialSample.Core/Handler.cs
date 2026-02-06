namespace SerialSample.Core;
public class Handler { public string Process() => "Serial port ready"; }
public class SerialConnection {
    public int BaudRate { get; set; } = 9600;
}