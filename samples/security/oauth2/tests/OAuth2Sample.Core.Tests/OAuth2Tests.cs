using Xunit;
using OAuth2Sample.Core;
namespace OAuth2Sample.Core.Tests;
public class OAuth2Tests {
    [Fact] public void Authenticate_SetsToken() {
        var client = new OAuth2Client();
        Assert.True(client.Authenticate("user123"));
        Assert.NotNull(client.AccessToken);
    }
}