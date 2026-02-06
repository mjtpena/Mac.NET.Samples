namespace OAuth2Sample.Core;
public class Handler { public string Process() => "OAuth2 ready"; }
public class OAuth2Client {
    public string? AccessToken { get; set; }
    public bool Authenticate(string cred) {
        if (string.IsNullOrEmpty(cred)) return false;
        AccessToken = "token_" + cred;
        return true;
    }
}