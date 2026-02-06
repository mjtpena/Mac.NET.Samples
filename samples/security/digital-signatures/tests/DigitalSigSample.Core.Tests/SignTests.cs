using Xunit;
using DigitalSigSample.Core;
namespace DigitalSigSample.Core.Tests;
public class SignTests {
    [Fact] public void Sign_ProducesSignature() {
        var signer = new Signer();
        var sig = signer.Sign("data");
        Assert.NotNull(sig);
    }
}