using NaotCliSample;

var argsParser = new ArgsParser();
var result = argsParser.Parse(args);

Console.WriteLine(result.Message);

return result.ExitCode;

public partial class Program;
