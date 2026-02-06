namespace DigitalSigSample.Core;
public class Handler { public string Process() => "Digital signatures ready"; }
public class Signer {
    private string _privateKey = "key123";
    public string Sign(string data) => "sig_" + data.GetHashCode().ToString();
    public bool Verify(string data, string sig) => sig == "sig_" + data.GetHashCode().ToString();
}