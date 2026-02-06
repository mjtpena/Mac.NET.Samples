using Xunit;
using TlsSslSample.Core;
namespace TlsSslSample.Core.Tests;
public class TlsTests {
    [Fact] public void DefaultProtocol_IsTls12() {
        var conn = new SecureConnection();
        Assert.Equal("TLS1.2", conn.Protocol);
    }
}