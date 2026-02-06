using Xunit;
using PinvokeSample.Core;

namespace PinvokeSample.Core.Tests;

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