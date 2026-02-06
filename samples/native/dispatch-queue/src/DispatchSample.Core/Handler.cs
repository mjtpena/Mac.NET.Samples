namespace DispatchSample.Core;
public class Handler { public string Process() => "Dispatch queue ready"; }
public class DispatchQueue {
    private Queue<Action> _tasks = new();
    public void Enqueue(Action task) => _tasks.Enqueue(task);
    public void Flush() { while (_tasks.Count > 0) _tasks.Dequeue()(); }
}