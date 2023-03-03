using ApiGateway.Aggregators;

using ApiGateway.Handlers;

using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot()
    .AddDelegatingHandler<RemoveEncodingDelegatingHandler>(true)
    .AddSingletonDefinedAggregator<UsersPostsAggregator>();

var app = builder.Build();


//app.UseAuthentication();
//app.UseAuthorization();

app.UseOcelot().Wait();

app.Run();
