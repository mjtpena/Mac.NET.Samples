using Xunit;
using MemoryLeaksSample.Core;

namespace MemoryLeaksSample.Core.Tests;

public class HandlerTests
{
[Fact]
public void Process_ReturnsReady()
{
var handler = new Handler();
var result = handler.Process();
Assert.Equal("Ready", result);
}
}