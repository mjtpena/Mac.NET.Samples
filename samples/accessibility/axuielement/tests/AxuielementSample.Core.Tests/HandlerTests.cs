using Xunit;
using AxUIElementSample.Core;

namespace AxUIElementSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsCorrectMessage()
    {
        var handler = new Handler();
        Assert.Contains("accessibility", handler.Process());
    }
    
    [Fact]
    public void AccessibleElement_CanAddChildren()
    {
        var parent = new AccessibleElement { Role = "Window", Title = "Test" };
        var child = new AccessibleElement { Role = "Button", Title = "OK" };
        
        parent.AddChild(child);
        
        Assert.Single(parent.Children);
        Assert.Equal(child, parent.Children[0]);
    }
    
    [Fact]
    public void AccessibleElement_CanFindByRole()
    {
        var root = new AccessibleElement { Role = "Window" };
        var button = new AccessibleElement { Role = "Button" };
        
        root.AddChild(button);
        root.AddChild(new AccessibleElement { Role = "TextField" });
        
        var buttons = root.FindByRole("Button").ToList();
        
        Assert.Equal(1, buttons.Count);
        Assert.Equal("Button", buttons[0].Role);
    }
    
    [Fact]
    public void AccessibilityEventDispatcher_DispatchesEvents()
    {
        var dispatcher = new AccessibilityEventDispatcher();
        var eventFired = false;
        
        dispatcher.Subscribe("focus", _ => eventFired = true);
        dispatcher.RaiseEvent("focus", "Button gained focus");
        
        Assert.True(eventFired);
    }
}
