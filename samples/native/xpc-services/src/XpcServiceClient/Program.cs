using XpcService.Core;

// XPC client: sends messages to the daemon
// In a real app, this would use xpc_connection_create_mach_service()

var router = new MessageRouter();
router.Register("ping", _ => "pong");
router.Register("echo", payload => payload);
router.Register("info", _ => $"XPC Client at {DateTimeOffset.UtcNow:O}");

Console.WriteLine("[XPC Client] Sending messages to daemon");

var pingMsg = XpcMessage.Create("ping", "");
Console.WriteLine($"[XPC Client] Sent: {pingMsg.Type}");

var echoMsg = XpcMessage.Create("echo", "hello from client");
Console.WriteLine($"[XPC Client] Sent: {echoMsg.Type} = {echoMsg.Payload}");

var infoMsg = XpcMessage.Create("info", "");
Console.WriteLine($"[XPC Client] Sent: {infoMsg.Type}");

Console.WriteLine("[XPC Client] Done");
