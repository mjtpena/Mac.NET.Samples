# Worker + launchd (macOS)

A .NET 10 Worker Service intended to run as a background process managed by launchd.

## Prerequisites

- .NET 10 SDK

## Build and run

From this folder:

- `dotnet restore`
- `dotnet run --project src/WorkerLaunchdSample`

## Tests

- `dotnet test tests/WorkerLaunchdSample.Tests/WorkerLaunchdSample.Tests.csproj`

## launchd

A sample plist is available at:

- `launchd/com.example.worker.plist`

Edit the paths in the plist to match your local build output.
