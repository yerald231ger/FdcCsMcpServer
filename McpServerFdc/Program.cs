using McpServerFdc.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = Host.CreateApplicationBuilder(args);
builder.Logging.AddConsole(consoleLogOptions =>
{
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services.AddHttpClient();
builder.Services.AddSingleton<FdcService>();

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

var app = builder.Build();

// var fdcService = app.Services.GetRequiredService<FdcService>();
//
// var deliveries = await fdcService.GetTankDelivery(null);

await app.RunAsync();