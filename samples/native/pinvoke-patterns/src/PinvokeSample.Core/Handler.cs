namespace PinvokeSample.Core;
public class Handler { public string Process() => "P/Invoke patterns ready"; }
public class NativeLib {
    public static int CallNative() => 42;
}