namespace TpmSample.Core;
public class Handler { public string Process() => "TPM operations ready"; }
public class TpmModule {
    public string GetVersion() => "2.0";
}