using System.Text.Json.Serialization;
using Api.Modules.Car;
using Api.Modules.Part;
using Api.Modules.PartReplacement;
using Infrastructure;
using Infrastructure.Storage;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure();

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.AddCarEndpoints();
app.AddPartEndpoints();
app.AddPartReplacementEndpoints();

app.Run();
