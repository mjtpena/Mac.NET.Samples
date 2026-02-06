using Xunit;
using PasteSample.Core;
namespace PasteSample.Core.Tests;
public class PasteTests {
    [Fact] public void Copy_Then_Paste() {
        var pb = new Pasteboard();
        pb.Copy("hello");
        Assert.Equal("hello", pb.Paste());
    }
}