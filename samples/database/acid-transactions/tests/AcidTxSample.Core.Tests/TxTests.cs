using Xunit;
using AcidTxSample.Core;
namespace AcidTxSample.Core.Tests;
public class TxTests {
    [Fact] public void Commit_MarksCommitted() {
        var mgr = new TransactionManager();
        mgr.Commit("tx1");
        Assert.True(mgr.IsCommitted("tx1"));
    }
}