using ObjcRuntimeSample.Core;

namespace ObjcRuntimeSample.Core.Tests;

public sealed class MessageFormatterTests
{
    [Fact]
    public void Format_UsesFallbacks()
    {
        var result = MessageFormatter.Format(" ", " ");

        Assert.Contains("(unknown)", result, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void Format_IncludesValues()
    {
        var result = MessageFormatter.Format("Process", "14.4");

        Assert.Contains("Process", result, StringComparison.OrdinalIgnoreCase);
        Assert.Contains("14.4", result, StringComparison.OrdinalIgnoreCase);
    }
}
