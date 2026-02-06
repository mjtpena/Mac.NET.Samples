namespace PasteSample.Core;
public class Handler { public string Process() => "Pasteboard ready"; }
public class Pasteboard {
    private string _content = "";
    public void Copy(string text) => _content = text;
    public string Paste() => _content;
}