using System.Runtime.InteropServices;
using XpcService.Core;

// XPC daemon: runs as a background process managed by launchd
// Routes incoming XPC messages to handlers

var router = new MessageRouter();

router.Register("ping", _ => "pong");
router.Register("echo", payload => payload);
router.Register("info", _ => $"XPC Daemon running at {DateTimeOffset.UtcNow:O}");

// In a real XPC service, this would listen on xpc_connection_t
// For now, we demonstrate message routing logic with test data
Console.WriteLine("[XPC Daemon] Initialized");

var testMessage = XpcMessage.Create("ping", "");
var response = router.Route(testMessage);
Console.WriteLine($"[XPC Daemon] {testMessage.Type} -> {response}");

var echoMessage = XpcMessage.Create("echo", "hello from daemon");
var echoResponse = router.Route(echoMessage);
Console.WriteLine($"[XPC Daemon] {echoMessage.Type} -> {echoResponse}");

var infoMessage = XpcMessage.Create("info", "");
var infoResponse = router.Route(infoMessage);
Console.WriteLine($"[XPC Daemon] {infoMessage.Type} -> {infoResponse}");

Console.WriteLine("[XPC Daemon] Ready for XPC connections");
