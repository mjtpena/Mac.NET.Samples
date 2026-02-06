using Xunit;
using SqliteCustomSample.Core;

namespace SqliteCustomSample.Core.Tests;

public class DatabaseTests
{
    [Fact]
    public void Insert_AddsRow()
    {
        var db = new SimpleDatabase();
        db.Insert(1, "test");
        Assert.Equal(1, db.GetRowCount());
    }

    [Fact]
    public void Query_ReturnsValue()
    {
        var db = new SimpleDatabase();
        db.Insert(1, "hello");
        var result = db.Query(1);
        Assert.Equal("hello", result);
    }

    [Fact]
    public void Delete_RemovesRow()
    {
        var db = new SimpleDatabase();
        db.Insert(1, "data");
        Assert.True(db.Delete(1));
        Assert.Null(db.Query(1));
    }
}