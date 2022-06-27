using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using RestSharp;

namespace my_contribution;

public record Response([property:JsonPropertyName("full_name")] string FullName);

public static class GithubApi
{
    private static readonly RestClient Client = new RestClient("https://api.github.com");

    public static async IAsyncEnumerable<string> GetReposAsync(string githubId, [EnumeratorCancellation] CancellationToken ct = default)
        => Client.StreamJsonAsync<Response>($"users/{githubId}/repos", ct)
            .SelectAwait(response => ValueTask.FromResult(response.FullName));
    // Todo : from result 대신 async parsing method
}