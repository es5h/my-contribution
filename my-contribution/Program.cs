using my_contribution;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var gitHubClient = new RestClient("http://api.github.com");

Task<string> ReturnTestAsync(string msg) => Task.FromResult(msg);

app.MapGet("/test", ReturnTestAsync);

app.MapGet("/test/{id}", TestService.IdentityStringAsync);

app.Run();

public partial class Program { }