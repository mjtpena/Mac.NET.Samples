using Xunit;
using SerialPortSample.Core;

namespace SerialPortSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsMessage()
    {
        var handler = new Handler();
        Assert.Contains("Serial", handler.Process());
    }
    
    [Fact]
    public void SerialPortConnection_Opens()
    {
        var conn = new SerialPortConnection { Port = "COM1" };
        conn.Open();
        Assert.True(conn.IsOpen);
    }
    
    [Fact]
    public void SerialPortConnection_WritesData()
    {
        var conn = new SerialPortConnection();
        conn.Open();
        conn.Write("test");
        
        var data = conn.GetReceivedData().ToList();
        Assert.Single(data);
        Assert.Equal("test", data[0]);
    }
}
