using Xunit;
using TpmSample.Core;
namespace TpmSample.Core.Tests;
public class TpmTests {
    [Fact] public void GetVersion_Returns20() {
        var tpm = new TpmModule();
        Assert.Equal("2.0", tpm.GetVersion());
    }
}