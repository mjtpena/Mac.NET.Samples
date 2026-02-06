using Xunit;
using GesturesSample.Core;
namespace GesturesSample.Core.Tests;
public class GestureTests {
    [Fact] public void OnGesture_RecordsGesture() {
        var detector = new GestureDetector();
        detector.OnGesture("swipe");
        Assert.Equal("swipe", detector.GetLastGesture());
    }
}