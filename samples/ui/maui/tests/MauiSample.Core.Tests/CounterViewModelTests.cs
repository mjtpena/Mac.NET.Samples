using MauiSample.Core;

namespace MauiSample.Core.Tests;

public sealed class CounterViewModelTests
{
    [Fact]
    public void IncrementCommand_UpdatesCount()
    {
        var viewModel = new CounterViewModel();

        Assert.Equal(0, viewModel.Count);

        viewModel.IncrementCommand.Execute(null);
        viewModel.IncrementCommand.Execute(null);

        Assert.Equal(2, viewModel.Count);
        Assert.Equal("Count: 2", viewModel.Title);
    }
}
