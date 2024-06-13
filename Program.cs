using dotpics;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Queries>();

var app = builder.Build();
app.MapGraphQL();
app.Run();