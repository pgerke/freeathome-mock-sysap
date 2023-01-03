using Microsoft.AspNetCore.WebSockets;
using PhilipGerke.FreeAtHome.MockSysAP.Library.Models;
using PhilipGerke.FreeAtHome.MockSysAP.Web.Services;

// Create web application builder
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Configure Logging
builder.Logging.ClearProviders();
//builder.Logging.AddJsonConsole(options => options.UseUtcTimestamp = true);
builder.Logging.AddConsole();

// Configure Services
builder.Services
    .AddControllers()
    .AddNewtonsoftJson(
        options => options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore);

builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();
builder.Services
    .AddHttpLogging(options => options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All);
builder.Services
    .AddWebSockets(
        options =>
        {
        });
builder.Services.AddSingleton<ISystemAccessPointService<SystemAccessPoint>>(provider => new SystemAccessPointService());
builder.Services.AddSingleton<IUpdateService<WebSocketMessageContent>>(provider => new UpdateService());

WebApplication app = builder.Build();

app.UseWebSockets();
app.MapControllers();
app.MapHealthChecks("health");
app.UseSwagger();
app.UseSwaggerUI(
    options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });

app.Run();
