using System.ComponentModel;
using System.Text.Json;
using McpServerFdc.Services;
using Microsoft.Extensions.Logging;
using ModelContextProtocol.Server;

namespace McpServerFdc.Tools;

[McpServerToolType]
public class FdcTool
{
    [McpServerTool, Description("Get the latest tank delivery data for all tanks.")]
    public async Task<string> GetTankDelivery(FdcService fdcService, ILogger<FdcTool> logger)
    {
        logger.LogInformation("Get latest tank delivery data");
        var response = await fdcService.GetTankDelivery(null);
        return JsonSerializer.Serialize(response);
    }
    
    [McpServerTool, Description("Get the latest tank delivery data for a specific tank.")]
    public async Task<string> GetTanksDeliveries(FdcService fdcService, ILogger<FdcTool> logger, [Description("The tank id, and specified also as device id")]int deviceId)
    {
        logger.LogInformation("Get latest tanks deliveries data");
        var response = await fdcService.GetTankDelivery(deviceId);
        return JsonSerializer.Serialize(response);
    }
}

