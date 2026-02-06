using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MinimalApiSample.Tests;

public sealed class ProgramTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ProgramTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Root_Returns_Metadata()
    {
        var response = await _client.GetAsync("/");
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<Dictionary<string, object>>();
        Assert.NotNull(payload);
        Assert.True(payload!.ContainsKey("name"));
        Assert.True(payload.ContainsKey("framework"));
    }

    [Fact]
    public async Task Health_Returns_Healthy()
    {
        var response = await _client.GetAsync("/health");
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Items_Crud_Works()
    {
        var listResponse = await _client.GetAsync("/items");
        listResponse.EnsureSuccessStatusCode();

        var createResponse = await _client.PostAsJsonAsync("/items", new { name = "Test", description = "Item" });
        Assert.Equal(HttpStatusCode.Created, createResponse.StatusCode);

        var created = await createResponse.Content.ReadFromJsonAsync<ItemDto>();
        Assert.NotNull(created);
        Assert.True(created!.Id > 0);

        var getResponse = await _client.GetAsync($"/items/{created.Id}");
        getResponse.EnsureSuccessStatusCode();

        var deleteResponse = await _client.DeleteAsync($"/items/{created.Id}");
        Assert.Equal(HttpStatusCode.NoContent, deleteResponse.StatusCode);

        var notFoundResponse = await _client.GetAsync($"/items/{created.Id}");
        Assert.Equal(HttpStatusCode.NotFound, notFoundResponse.StatusCode);
    }

    private sealed record ItemDto(int Id, string Name, string Description);
}
