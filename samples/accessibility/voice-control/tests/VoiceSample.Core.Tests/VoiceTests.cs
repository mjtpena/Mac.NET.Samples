using Xunit;
using VoiceSample.Core;
namespace VoiceSample.Core.Tests;
public class VoiceTests {
    [Fact] public void ExecuteCommand_RecordsCommand() {
        var vc = new VoiceCommand();
        vc.ExecuteCommand("click button");
        Assert.Equal("click button", vc.LastCommand);
    }
}