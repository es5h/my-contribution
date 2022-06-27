using System.Runtime.CompilerServices;
using RestSharp;

namespace my_contribution;

public record Response(string FullName);

public static class GithubApi
{
    private static RestClient Client => new RestClient("https//api.github.com");

    public static async IAsyncEnumerable<string> GetReposAsync(string githubId, [EnumeratorCancellation] CancellationToken ct = default)
    {
        var response = Client.StreamJsonAsync<Response>($"/users/{githubId}/repos", ct);

        await foreach (var item in response.WithCancellation(ct))
        {
            yield return item.FullName;
        }
    }

}