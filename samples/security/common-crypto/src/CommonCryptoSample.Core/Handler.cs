namespace CommonCryptoSample.Core;
public class Handler { public string Process() => "CommonCrypto ready"; }
public class CryptoUtils {
    public static string Hash(string input) {
        using var sha = System.Security.Cryptography.SHA256.Create();
        var hash = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
        return Convert.ToHexString(hash);
    }
}