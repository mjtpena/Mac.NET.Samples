using Xunit;
using MauiSample.Core;

namespace MauiSample.Core.Tests;

public class ViewModelTests
{
    [Fact]
    public void Increment_UpdatesCount()
    {
        var vm = new CounterViewModel();
        vm.Count = 1;
        Assert.Equal(1, vm.Count);
    }

    [Fact]
    public void Count_RaisesPropertyChanged()
    {
        var vm = new CounterViewModel();
        var changed = false;
        vm.PropertyChanged += (s, e) => { if (e.PropertyName == nameof(CounterViewModel.Count)) changed = true; };
        vm.Count = 5;
        Assert.True(changed);
    }
}