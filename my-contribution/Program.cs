using my_contribution;
using RestSharp;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/test", TestService.ReturnTestAsync);

app.MapGet("/test/{id}", TestService.IdentityStringAsync);

app.Run();

public partial class Program { }