using Xunit;
using MidiSample.Core;
namespace MidiSample.Core.Tests;
public class MidiTests {
    [Fact] public void PlayNote_RecordsNote() {
        var seq = new MidiSequencer();
        seq.PlayNote(60, 127, 500);
        Assert.Equal(1, seq.NoteCount);
    }
}