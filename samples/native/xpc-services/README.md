# XPC Services (macOS)

A .NET 10 macOS daemon and service that use Apple's XPC (inter-process communication) framework. This is enterprise-grade low-level macOS integration: launchd daemon, XPC message passing, and type-safe marshalling.

## Prerequisites

- .NET 10 SDK
- macOS workload
- Xcode (for signing/codesigning)

## Build and run

From this folder:

- `dotnet restore`
- `dotnet build src/XpcServiceDaemon`
- `dotnet build src/XpcServiceClient`
- See README for daemon installation and client usage

## Tests

- `dotnet test tests/XpcService.Core.Tests/XpcService.Core.Tests.csproj`

## Technical details

- Uses `libxpc.dylib` for XPC messaging
- launchd plist for daemon auto-start
- Message routing and serialization
