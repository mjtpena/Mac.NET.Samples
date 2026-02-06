namespace MmapIOSample.Core;

public sealed class MemoryBuffer
{
    private byte[] _buffer;

    public MemoryBuffer(int size)
    {
        _buffer = new byte[size];
    }

    public void Write(int offset, byte value)
    {
        if (offset >= 0 && offset < _buffer.Length)
        {
            _buffer[offset] = value;
        }
    }

    public byte Read(int offset)
    {
        return (offset >= 0 && offset < _buffer.Length) ? _buffer[offset] : (byte)0;
    }

    public int Size => _buffer.Length;
}
