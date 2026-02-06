namespace VoiceControlSample.Core;

/// <summary>
/// Voice control recognition and processing.
/// </summary>
public class Handler
{
    public string Process() => "Voice control engine ready";
}

public class VoiceCommand
{
    public string Command { get; set; } = string.Empty;
    public float Confidence { get; set; }
    public DateTime RecognizedAt { get; set; }
}

public class VoiceRecognitionEngine
{
    private readonly Dictionary<string, Action> _commandHandlers = new(StringComparer.OrdinalIgnoreCase);
    private readonly List<VoiceCommand> _history = new();
    
    public void RegisterCommand(string command, Action handler) => _commandHandlers[command] = handler;
    
    public VoiceCommand ProcessAudioInput(string recognizedText, float confidence)
    {
        var command = new VoiceCommand 
        { 
            Command = recognizedText, 
            Confidence = confidence,
            RecognizedAt = DateTime.UtcNow
        };
        _history.Add(command);
        
        if (confidence >= 0.8f && _commandHandlers.TryGetValue(recognizedText, out var handler))
            handler();
        
        return command;
    }
    
    public IEnumerable<VoiceCommand> GetHistory() => _history.AsReadOnly();
}
