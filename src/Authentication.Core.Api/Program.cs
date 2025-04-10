

using Microsoft.EntityFrameworkCore;
using Shared.Core;

var builder = WebApplication.CreateBuilder(args);
var Cors = "Cors";
var environment = builder.Environment.EnvironmentName;
var allowedOrigins = environment == "Development"
    ? new[] { "http://localhost:4200" }
    : new[] { "https://mi-sitio.com", "https://api.mi-sitio.com" };

// Add services to the container.
var configuration = builder.Configuration;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors,
        builder =>
        {
            builder.WithOrigins(allowedOrigins);
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.AddMiddleware();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
