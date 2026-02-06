# MAUI (Mac Catalyst)

A minimal .NET 10 MAUI app targeting Mac Catalyst with shared UI logic in a testable core library.

## Prerequisites

- .NET 10 SDK
- MAUI workloads

## Build and run

From this folder:

- `dotnet restore`
- `dotnet build src/MauiSample`
- `dotnet run --project src/MauiSample -f net10.0-maccatalyst`

## Tests

- `dotnet test tests/MauiSample.Core.Tests/MauiSample.Core.Tests.csproj`

## Debugging

Use the MAUI debug configuration in your editor for `net10.0-maccatalyst` after restoring workloads.
