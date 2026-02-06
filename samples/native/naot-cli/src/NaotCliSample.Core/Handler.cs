namespace NaotCliSample.Core;

public class Handler
{
    public string Process() => "NativeAOT CLI ready";
    
    public static class ArgsParser
    {
        public static (string Command, bool Help, string? Arg) Parse(string[] args)
        {
            var help = args.Contains("--help") || args.Contains("-h");
            var cmd = args.FirstOrDefault(a => !a.StartsWith("-")) ?? "default";
            var arg = args.SkipWhile(a => !a.StartsWith("--arg")).Skip(1).FirstOrDefault();
            return (cmd, help, arg);
        }
    }
}