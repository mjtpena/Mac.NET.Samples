namespace MemMapSample.Core;
public class Handler { public string Process() => "Memory mapped IO ready"; }
public class MemoryBuffer {
    private byte[] _buffer;
    public MemoryBuffer(int size) => _buffer = new byte[size];
    public void WriteByte(int offset, byte value) => _buffer[offset] = value;
    public byte ReadByte(int offset) => _buffer[offset];
}