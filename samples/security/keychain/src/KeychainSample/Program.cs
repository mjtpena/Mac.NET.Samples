using System.Runtime.InteropServices;
using Foundation;
using Security;
using KeychainSample.Core;

const string service = "com.example.keychainsample";
const string account = "demo";
const string secret = "secret-from-dotnet";

var entry = new KeychainEntry(service, account, secret);
Console.WriteLine(KeychainFormatter.FormatDisplay(entry));

if (!RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    Console.WriteLine("Keychain is only available on macOS.");
    return;
}

var record = new SecRecord(SecKind.GenericPassword)
{
    Service = service,
    Account = account,
    Generic = NSData.FromString(secret)
};

SecKeyChain.Remove(record);
var status = SecKeyChain.Add(record);
Console.WriteLine($"Add status: {status}");

var query = new SecRecord(SecKind.GenericPassword)
{
    Service = service,
    Account = account
};

var match = SecKeyChain.QueryAsRecord(query, out var queryStatus);
Console.WriteLine($"Query status: {queryStatus}");

if (match is not null)
{
    var data = match.Generic;
    var retrieved = data is null ? string.Empty : NSString.FromData(data, NSStringEncoding.UTF8);
    Console.WriteLine($"Retrieved: {retrieved}");
}
