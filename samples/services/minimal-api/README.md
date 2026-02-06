# Minimal API (macOS)

A lightweight .NET 10 Minimal API sample intended for local macOS development.

## Prerequisites

- .NET 10 SDK

## Build and run

From this folder:

- `dotnet restore`
- `dotnet run --project src/MinimalApiSample`

## Tests

- `dotnet test tests/MinimalApiSample.Tests/MinimalApiSample.Tests.csproj`

The API listens on `http://localhost:5080` by default.

## Endpoints

- GET `/` – basic info
- GET `/items` – list items
- GET `/items/{id}` – get by id
- POST `/items` – create item
- DELETE `/items/{id}` – delete item
