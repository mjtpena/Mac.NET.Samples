using Xunit;
using ChaosSample.Core;
namespace ChaosSample.Core.Tests;
public class ChaosTests {
    [Fact] public void InjectFault_DetectsFault() {
        var monkey = new ChaosMonkey();
        Assert.True(monkey.InjectFault("network-delay"));
    }
}