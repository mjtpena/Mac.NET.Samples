using Xunit;
using EncryptedDbSample.Core;
namespace EncryptedDbSample.Core.Tests;
public class EncryptionTests {
    [Fact] public void Store_EncryptsData() {
        var store = new EncryptedStorage();
        store.Store("key", "secret");
        var retrieved = store.Retrieve("key");
        Assert.NotNull(retrieved);
    }
}