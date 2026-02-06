using Xunit;
using SerialSample.Core;
namespace SerialSample.Core.Tests;
public class SerialTests {
    [Fact] public void BaudRate_HasDefault() {
        var conn = new SerialConnection();
        Assert.Equal(9600, conn.BaudRate);
    }
}