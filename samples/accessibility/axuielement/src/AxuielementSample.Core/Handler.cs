namespace AxUIElementSample.Core;

/// <summary>
/// AXUIElement accessibility provider for macOS.
/// </summary>
public class Handler
{
    public string Process() => "AXUIElement accessibility provider initialized";
}

public class AccessibleElement
{
    public string Role { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public bool Enabled { get; set; } = true;
    public List<AccessibleElement> Children { get; private set; } = new();
    
    public void AddChild(AccessibleElement child) => Children.Add(child);
    
    public IEnumerable<AccessibleElement> FindByRole(string role)
    {
        if (Role == role) yield return this;
        foreach (var child in Children)
            foreach (var found in child.FindByRole(role))
                yield return found;
    }
}

public class AccessibilityEventDispatcher
{
    private readonly List<(string EventType, Action<string> Handler)> _handlers = new();
    
    public void Subscribe(string eventType, Action<string> handler) => _handlers.Add((eventType, handler));
    
    public void RaiseEvent(string eventType, string details)
    {
        foreach (var (type, handler) in _handlers)
            if (type == eventType) handler(details);
    }
}
