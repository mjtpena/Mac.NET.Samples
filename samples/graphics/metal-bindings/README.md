# Metal bindings (macOS)

A minimal .NET 10 macOS AppKit app that creates an `MTKView` and clears the drawable using Metal. Includes a small, testable core library.

## Prerequisites

- .NET 10 SDK
- macOS workload

## Build and run

From this folder:

- `dotnet restore`
- `dotnet build src/MetalBindingsSample`
- `dotnet run --project src/MetalBindingsSample -f net10.0-macos`

## Tests

- `dotnet test tests/MetalBindingsSample.Core.Tests/MetalBindingsSample.Core.Tests.csproj`
