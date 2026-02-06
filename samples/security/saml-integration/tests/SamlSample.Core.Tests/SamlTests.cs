using Xunit;
using SamlSample.Core;
namespace SamlSample.Core.Tests;
public class SamlTests {
    [Fact] public void Authenticate_WithAssertion() {
        var client = new SamlClient();
        Assert.True(client.Authenticate("assertion123"));
    }
}