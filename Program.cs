//------------------------------------------------------------------------------
// <written-by>
//     This code was written by David Cardenas.
//     © 2024 David Cardenas. All rights reserved.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </written-by>
//------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using API_MySql_ASP.NET.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/// <summary>
/// Connection string variable.
/// </summary>
var connectionString = builder.Configuration.GetConnectionString("connection");

/// <summary>
/// Register services for the database context with the connection string.
/// </summary>
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(connectionString)
);

/// <summary>
/// Add services for controllers.
/// </summary>
builder.Services.AddControllers();

/// <summary>
/// Add services for Swagger/OpenAPI documentation.
/// </summary>
/// <remarks>
/// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
/// </remarks>
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    /// <summary>
    /// Enable Swagger middleware for API documentation in development environment.
    /// </summary>
    app.UseSwagger();
    app.UseSwaggerUI();
}

/// <summary>
/// Enable HTTPS redirection middleware.
/// </summary>
app.UseHttpsRedirection();

/// <summary>
/// Enable authorization middleware.
/// </summary>
app.UseAuthorization();

/// <summary>
/// Map controllers to endpoints.
/// </summary>
app.MapControllers();

/// <summary>
/// Run the application.
/// </summary>
app.Run();