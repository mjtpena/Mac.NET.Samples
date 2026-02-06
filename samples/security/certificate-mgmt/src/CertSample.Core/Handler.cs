namespace CertSample.Core;
public class Handler { public string Process() => "Certificate management ready"; }
public class CertManager {
    private List<string> _certs = new();
    public void ImportCertificate(string cert) => _certs.Add(cert);
    public int CertCount => _certs.Count;
}