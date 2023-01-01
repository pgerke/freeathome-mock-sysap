// Create web application builder
using Microsoft.AspNetCore.WebSockets;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Configure Logging
builder.Logging.AddConsole();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();
builder.Services
    .AddHttpLogging(options => options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All);
builder.Services
    .AddWebSockets(
        options =>
        {
        });

WebApplication app = builder.Build();

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
