namespace AcidTxSample.Core;
public class Handler { public string Process() => "ACID transactions ready"; }
public class TransactionManager {
    private List<string> _committed = new();
    public void Commit(string txId) => _committed.Add(txId);
    public bool IsCommitted(string txId) => _committed.Contains(txId);
}