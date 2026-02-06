# OpenTelemetry + dtrace (macOS)

A .NET 10 macOS app that exports traces and metrics to OpenTelemetry, and integrates with Apple's dtrace instrumentation framework.

## Prerequisites

- .NET 10 SDK
- macOS workload

## Build and run

From this folder:

- `dotnet restore`
- `dotnet run --project src/OtelTracingSample`

## Tests

- `dotnet test tests/OtelTracingSample.Core.Tests/OtelTracingSample.Core.Tests.csproj`
