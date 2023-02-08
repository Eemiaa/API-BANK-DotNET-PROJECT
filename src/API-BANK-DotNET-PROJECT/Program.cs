using Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterAPI();
builder.Services.AddDomainConfigs();

var app = builder.Build();

app.RegisterAPI();

app.AddEndpoints(builder.Services.BuildServiceProvider());

app.Run();
