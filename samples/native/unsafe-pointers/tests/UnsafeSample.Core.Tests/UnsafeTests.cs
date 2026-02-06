using Xunit;
using UnsafeSample.Core;
namespace UnsafeSample.Core.Tests;
public class UnsafeTests {
    [Fact] public unsafe void DereferencePointer_ReadsValue() {
        int value = 42;
        var result = UnsafeOps.DereferencePointer(&value);
        Assert.Equal(42, result);
    }
}