using Xunit;
using MinimalApiSample.Core;

namespace MinimalApiSample.Core.Tests;

public class ItemStoreTests
{
    [Fact]
    public void Add_ReturnsItemWithId()
    {
        var store = new ItemStore();
        var item = store.Add("test");
        Assert.NotEqual(0, item.Id);
        Assert.Equal("test", item.Name);
    }

    [Fact]
    public void Get_ReturnsAddedItem()
    {
        var store = new ItemStore();
        var added = store.Add("item");
        var retrieved = store.Get(added.Id);
        Assert.NotNull(retrieved);
        Assert.Equal("item", retrieved.Name);
    }

    [Fact]
    public void Delete_RemovesItem()
    {
        var store = new ItemStore();
        var item = store.Add("temp");
        Assert.True(store.Delete(item.Id));
        Assert.Null(store.Get(item.Id));
    }
}