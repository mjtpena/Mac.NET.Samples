namespace GesturesSample.Core;
public class Handler { public string Process() => "Gesture recognition ready"; }
public class GestureDetector {
    private string _lastGesture = "";
    public void OnGesture(string gesture) => _lastGesture = gesture;
    public string GetLastGesture() => _lastGesture;
}