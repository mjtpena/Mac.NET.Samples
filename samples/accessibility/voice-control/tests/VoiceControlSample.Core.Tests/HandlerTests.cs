using Xunit;
using VoiceControlSample.Core;

namespace VoiceControlSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsReadyMessage()
    {
        var handler = new Handler();
        Assert.Contains("ready", handler.Process());
    }
    
    [Fact]
    public void VoiceRecognitionEngine_ExecutesHighConfidenceCommands()
    {
        var engine = new VoiceRecognitionEngine();
        var executed = false;
        
        engine.RegisterCommand("open", () => executed = true);
        engine.ProcessAudioInput("open", 0.95f);
        
        Assert.True(executed);
    }
    
    [Fact]
    public void VoiceRecognitionEngine_IgnoresLowConfidenceCommands()
    {
        var engine = new VoiceRecognitionEngine();
        var executed = false;
        
        engine.RegisterCommand("open", () => executed = true);
        engine.ProcessAudioInput("open", 0.5f);
        
        Assert.False(executed);
    }
    
    [Fact]
    public void VoiceRecognitionEngine_KeepsHistory()
    {
        var engine = new VoiceRecognitionEngine();
        
        engine.ProcessAudioInput("open", 0.9f);
        engine.ProcessAudioInput("close", 0.85f);
        
        var history = engine.GetHistory().ToList();
        Assert.Equal(2, history.Count);
    }
}
