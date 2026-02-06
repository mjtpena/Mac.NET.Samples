namespace UnsafeSample.Core;
public class Handler { public string Process() => "Unsafe pointers ready"; }
public class UnsafeOps {
    public unsafe static int DereferencePointer(int* ptr) => *ptr;
}