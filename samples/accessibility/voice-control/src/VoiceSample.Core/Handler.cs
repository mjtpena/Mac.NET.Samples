namespace VoiceSample.Core;
public class Handler { public string Process() => "Voice control ready"; }
public class VoiceCommand {
    public string? LastCommand { get; private set; }
    public void ExecuteCommand(string cmd) => LastCommand = cmd;
}