using Xunit;
using EnclaveSample.Core;
namespace EnclaveSample.Core.Tests;
public class EnclaveTests {
    [Fact] public void IsAvailable_ReturnsTrue() {
        var enclave = new SecureEnclave();
        Assert.True(enclave.IsAvailable);
    }
}