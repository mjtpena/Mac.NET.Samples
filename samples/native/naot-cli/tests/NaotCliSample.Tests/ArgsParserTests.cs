namespace NaotCliSample.Tests;

public sealed class ArgsParserTests
{
    [Fact]
    public void Parse_WithNoArgs_ReturnsHint()
    {
        var parser = new ArgsParser();
        var result = parser.Parse([]);

        Assert.Equal(0, result.ExitCode);
        Assert.Contains("--help", result.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void Parse_WithHelp_ReturnsUsage()
    {
        var parser = new ArgsParser();
        var result = parser.Parse(["--help"]);

        Assert.Equal(0, result.ExitCode);
        Assert.Contains("Usage", result.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void Parse_WithName_ReturnsGreeting()
    {
        var parser = new ArgsParser();
        var result = parser.Parse(["--name", "Maui"]);

        Assert.Equal(0, result.ExitCode);
        Assert.Contains("Hello Maui", result.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void Parse_WithInvalidArgs_ReturnsError()
    {
        var parser = new ArgsParser();
        var result = parser.Parse(["--unknown"]);

        Assert.Equal(1, result.ExitCode);
        Assert.Contains("Invalid", result.Message, StringComparison.OrdinalIgnoreCase);
    }
}
