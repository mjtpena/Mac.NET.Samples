# Mac Catalyst (UIKit)

A minimal .NET 10 Mac Catalyst app using UIKit with a small, testable core library.

## Prerequisites

- .NET 10 SDK
- Mac Catalyst workload

## Build and run

From this folder:

- `dotnet restore`
- `dotnet build src/MacCatalystSample`
- `dotnet run --project src/MacCatalystSample -f net10.0-maccatalyst`

## Tests

- `dotnet test tests/MacCatalystSample.Core.Tests/MacCatalystSample.Core.Tests.csproj`
