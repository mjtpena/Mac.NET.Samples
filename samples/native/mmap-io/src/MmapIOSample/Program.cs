using MmapIOSample.Core;

var buf = new MemoryBuffer(1024);
buf.Write(0, 42);
buf.Write(1, 99);

Console.WriteLine($"[Memory-mapped I/O Sample]");
Console.WriteLine($"Buffer size: {buf.Size}");
Console.WriteLine($"Value at 0: {buf.Read(0)}");
Console.WriteLine($"Value at 1: {buf.Read(1)}");
