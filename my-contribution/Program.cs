using my_contribution;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var gitHubClient = new RestClient("https://api.github.com");

app.MapGet("/test", TestService.ReturnTestAsync);

app.MapGet("/test/{id}", TestService.IdentityStringAsync);

app.Run();

public partial class Program { }