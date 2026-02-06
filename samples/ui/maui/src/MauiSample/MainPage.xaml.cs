using MauiSample.Core;

namespace MauiSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new CounterViewModel();
    }
}
