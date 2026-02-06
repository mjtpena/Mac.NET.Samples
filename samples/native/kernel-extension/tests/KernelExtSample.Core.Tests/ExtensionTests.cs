using Xunit;
using KernelExtSample.Core;
namespace KernelExtSample.Core.Tests;
public class ExtensionTests {
    [Fact] public void IsSystemExtensionAvailable_ReturnsTrue() {
        var detector = new ExtensionDetector();
        Assert.True(detector.IsSystemExtensionAvailable());
    }
}