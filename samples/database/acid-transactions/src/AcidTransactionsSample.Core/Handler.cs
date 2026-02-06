namespace AcidSample.Core;

/// <summary>
/// ACID transaction properties in database operations.
/// </summary>
public class Handler
{
    public string Process() => "ACID transactions ready";
}

public class TransactionManager
{
    private readonly Dictionary<string, decimal> _accounts = new();
    private readonly object _lockObj = new();
    
    public void CreateAccount(string id, decimal balance)
    {
        lock (_lockObj)
            _accounts[id] = balance;
    }
    
    public bool Transfer(string from, string to, decimal amount)
    {
        lock (_lockObj)
        {
            if (!_accounts.ContainsKey(from) || !_accounts.ContainsKey(to))
                return false;
            if (_accounts[from] < amount)
                return false;
            
            _accounts[from] -= amount;
            _accounts[to] += amount;
            return true;
        }
    }
    
    public decimal GetBalance(string id)
    {
        lock (_lockObj)
            return _accounts.TryGetValue(id, out var bal) ? bal : 0m;
    }
}
