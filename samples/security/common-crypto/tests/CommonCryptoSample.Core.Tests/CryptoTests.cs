using Xunit;
using CommonCryptoSample.Core;
namespace CommonCryptoSample.Core.Tests;
public class CryptoTests {
    [Fact] public void Hash_ProducesConsistentOutput() {
        var h1 = CryptoUtils.Hash("test");
        var h2 = CryptoUtils.Hash("test");
        Assert.Equal(h1, h2);
    }
}