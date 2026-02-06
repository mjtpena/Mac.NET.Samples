# Keychain (macOS)

A .NET 10 console app that stores and retrieves a secret using the macOS Keychain (Security framework). Includes a small, testable core library.

## Prerequisites

- .NET 10 SDK
- macOS workload

## Build and run

From this folder:

- `dotnet restore`
- `dotnet run --project src/KeychainSample`

## Tests

- `dotnet test tests/KeychainSample.Core.Tests/KeychainSample.Core.Tests.csproj`

## Notes

This sample uses native Security APIs for Keychain access.
