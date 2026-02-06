using Xunit;
using EncryptedDbSample.Core;

namespace EncryptedDbSample.Core.Tests;

public class HandlerTests
{
    [Fact]
    public void Process_ReturnsInitializedMessage()
    {
        var handler = new Handler();
        Assert.Contains("encrypted", handler.Process());
    }
    
    [Fact]
    public void DataEncryptor_EncryptsAndDecrypts()
    {
        var encryptor = new DataEncryptor();
        var plainText = "Secret data";
        
        var encrypted = encryptor.Encrypt(plainText);
        var decrypted = encryptor.Decrypt(encrypted);
        
        Assert.Equal(plainText, decrypted);
        Assert.NotEqual(plainText, encrypted);
    }
}
