using Xunit;
using CertSample.Core;
namespace CertSample.Core.Tests;
public class CertTests {
    [Fact] public void ImportCertificate_RecordsCert() {
        var mgr = new CertManager();
        mgr.ImportCertificate("cert.pem");
        Assert.Equal(1, mgr.CertCount);
    }
}