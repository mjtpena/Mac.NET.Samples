namespace SamlSample.Core;
public class Handler { public string Process() => "SAML integration ready"; }
public class SamlClient {
    public bool Authenticate(string assertion) => !string.IsNullOrEmpty(assertion);
}