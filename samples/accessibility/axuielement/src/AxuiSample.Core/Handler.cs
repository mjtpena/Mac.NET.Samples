namespace AxuiSample.Core;
public class Handler { public string Process() => "AXUIElement ready"; }
public record AccessibilityElement(string Role, string Title, bool Enabled);
public class AccessibilityAutomation {
    private readonly List<AccessibilityElement> _elements = new();
    public void RegisterElement(string role, string title, bool enabled) => _elements.Add(new(role, title, enabled));
    public int GetElementCount() => _elements.Count;
    public List<AccessibilityElement> FindByRole(string role) => _elements.Where(e => e.Role == role).ToList();
}