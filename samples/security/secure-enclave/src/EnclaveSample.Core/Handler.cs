namespace EnclaveSample.Core;
public class Handler { public string Process() => "Secure Enclave ready"; }
public class SecureEnclave {
    public bool IsAvailable => true;
}