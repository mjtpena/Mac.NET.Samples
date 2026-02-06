using Xunit;
using NaotCliSample.Core;

namespace NaotCliSample.Core.Tests;

public class ArgsParserTests
{
    [Fact]
    public void Parse_WithHelpFlag_ReturnsHelp()
    {
        var result = Handler.ArgsParser.Parse(new[] { "--help" });
        Assert.True(result.Help);
    }

    [Fact]
    public void Parse_WithCommand_ReturnsParsedCommand()
    {
        var result = Handler.ArgsParser.Parse(new[] { "test", "--arg", "value" });
        Assert.Equal("test", result.Command);
        Assert.Equal("value", result.Arg);
    }

    [Fact]
    public void Parse_NoArgs_ReturnsDefault()
    {
        var result = Handler.ArgsParser.Parse(Array.Empty<string>());
        Assert.Equal("default", result.Command);
        Assert.False(result.Help);
    }
}