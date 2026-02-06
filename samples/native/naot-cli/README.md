# NativeAOT CLI (macOS)

A .NET 10 console app ready for NativeAOT publishing on macOS.

## Prerequisites

- .NET 10 SDK

## Build and run

From this folder:

- `dotnet restore`
- `dotnet run --project src/NaotCliSample`

## Tests

- `dotnet test tests/NaotCliSample.Tests/NaotCliSample.Tests.csproj`

## NativeAOT publish (example)

- `dotnet publish src/NaotCliSample -c Release -r osx-arm64 /p:PublishAot=true`
