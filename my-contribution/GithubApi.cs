using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using LaYumba.Functional;
using RestSharp;

namespace my_contribution;

public record Response([property: JsonPropertyName("full_name")] string FullName);

public static class GithubApi
{
    private static readonly RestClient Client = new RestClient("https://api.github.com");

    public static IAsyncEnumerable<object> GetReposAsync(string githubId)
    {
        return Client.StreamJsonAsync<object>($"users/{githubId}/repos", CancellationToken.None);
    }
}