using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiSample.Core;

public sealed class CounterViewModel : INotifyPropertyChanged
{
    private int _count;

    public event PropertyChangedEventHandler? PropertyChanged;

    public int Count
    {
        get => _count;
        private set
        {
            if (_count == value)
            {
                return;
            }

            _count = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Title));
        }
    }

    public string Title => $"Count: {Count}";

    public ICommand IncrementCommand { get; }

    public CounterViewModel()
    {
        IncrementCommand = new RelayCommand(() => Count++);
    }

    private void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
