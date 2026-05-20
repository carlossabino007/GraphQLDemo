using GraphQLDemo.GraphQL;
using GraphQLDemo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ProductoService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();