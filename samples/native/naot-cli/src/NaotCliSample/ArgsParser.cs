namespace NaotCliSample;

public sealed class ArgsParser
{
    public ParseResult Parse(string[] args)
    {
        if (args.Length == 0)
        {
            return new ParseResult(0, "NaotCliSample: pass --help for options.");
        }

        if (args.Contains("--help", StringComparer.OrdinalIgnoreCase))
        {
            return new ParseResult(0, "Usage: naot-cli [--help] [--name <value>]");
        }

        var nameIndex = Array.FindIndex(args, arg => arg.Equals("--name", StringComparison.OrdinalIgnoreCase));
        if (nameIndex >= 0 && nameIndex + 1 < args.Length)
        {
            return new ParseResult(0, $"Hello {args[nameIndex + 1]} from .NET 10 on macOS.");
        }

        return new ParseResult(1, "Invalid arguments. Use --help.");
    }
}
