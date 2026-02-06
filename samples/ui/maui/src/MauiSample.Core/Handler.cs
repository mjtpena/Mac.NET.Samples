namespace MauiSample.Core;

public class Handler { public string Process() => "MAUI ready"; }

public class CounterViewModel : INotifyPropertyChanged
{
    private int _count;
    public int Count
    {
        get => _count;
        set { if (_count != value) { _count = value; OnPropertyChanged(); } }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}