# Objective‑C runtime interop (macOS)

A .NET 10 macOS app that calls the Objective‑C runtime directly (`objc_msgSend`) to fetch system details. This is a low‑level interop sample intended to show “hardcore” .NET + macOS integration.

## Prerequisites

- .NET 10 SDK
- macOS workload

## Build and run

From this folder:

- `dotnet restore`
- `dotnet build src/ObjcRuntimeSample`
- `dotnet run --project src/ObjcRuntimeSample -f net10.0-macos`

## Tests

- `dotnet test tests/ObjcRuntimeSample.Core.Tests/ObjcRuntimeSample.Core.Tests.csproj`
