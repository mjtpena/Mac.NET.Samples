namespace TlsSslSample.Core;
public class Handler { public string Process() => "TLS/SSL ready"; }
public class SecureConnection {
    public bool IsTlsEnabled { get; set; }
    public string Protocol { get; set; } = "TLS1.2";
}