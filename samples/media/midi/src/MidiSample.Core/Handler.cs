namespace MidiSample.Core;
public class Handler { public string Process() => "MIDI ready"; }
public record MidiNote(int NoteNumber, int Velocity, int DurationMs);
public class MidiSequencer {
    private List<MidiNote> _notes = new();
    public void PlayNote(int note, int vel, int dur) => _notes.Add(new(note, vel, dur));
    public int NoteCount => _notes.Count;
}