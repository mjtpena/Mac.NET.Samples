# AppKit interop (macOS)

A minimal .NET 10 macOS AppKit app with a small, testable core library.

## Prerequisites

- .NET 10 SDK
- macOS workload

## Build and run

From this folder:

- `dotnet restore`
- `dotnet build src/AppKitInteropSample`
- `dotnet run --project src/AppKitInteropSample -f net10.0-macos`

## Tests

- `dotnet test tests/AppKitInteropSample.Core.Tests/AppKitInteropSample.Core.Tests.csproj`
