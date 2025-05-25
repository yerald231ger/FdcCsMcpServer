using System.Text.Json.Serialization;
// ReSharper disable InconsistentNaming

namespace McpServerFdc.Models;

public record TankDeliveryResponse(
    [property: JsonPropertyName("RequestType")] string RequestType,
    [property: JsonPropertyName("ApplicationSender")] string ApplicationSender,
    [property: JsonPropertyName("WorkstationID")] string WorkstationID,
    [property: JsonPropertyName("RequestID")] int RequestID,
    [property: JsonPropertyName("OverallResult")] string OverallResult,
    [property: JsonPropertyName("FDCdata")] FdcData FDCdata
);

public record FdcData(
    [property: JsonPropertyName("FDCTimeStamp")] string FDCTimeStamp,
    [property: JsonPropertyName("DeviceClasses")] List<DeviceClass> DeviceClasses
);

public record DeviceClass(
    [property: JsonPropertyName("Type")] string Type,
    [property: JsonPropertyName("DeviceID")] int DeviceID,
    [property: JsonPropertyName("DeliveryData")] DeliveryData DeliveryData,
    [property: JsonPropertyName("ErrorCode")] string ErrorCode
);

public record DeliveryData(
    [property: JsonPropertyName("StartingDateTime")] string StartingDateTime,
    [property: JsonPropertyName("EndingDateTime")] string EndingDateTime,
    [property: JsonPropertyName("StartingHeight")] float StartingHeight,
    [property: JsonPropertyName("StartingVolume")] float StartingVolume,
    [property: JsonPropertyName("StartingVolumeTC")] float StartingVolumeTC,
    [property: JsonPropertyName("EndingHeight")] float EndingHeight,
    [property: JsonPropertyName("EndingVolume")] float EndingVolume,
    [property: JsonPropertyName("EndingVolumeTC")] float EndingVolumeTC,
    [property: JsonPropertyName("DeliveredVolume")] float DeliveredVolume,
    [property: JsonPropertyName("DeliveredVolumeTC")] float DeliveredVolumeTC,
    [property: JsonPropertyName("StartingWaterHeight")] float StartingWaterHeight,
    [property: JsonPropertyName("StartingWaterVolume")] float StartingWaterVolume,
    [property: JsonPropertyName("EndingWaterHeight")] float EndingWaterHeight,
    [property: JsonPropertyName("EndingWaterVolume")] float EndingWaterVolume,
    [property: JsonPropertyName("StartingTemperature")] float StartingTemperature,
    [property: JsonPropertyName("EndingTemperature")] float EndingTemperature,
    [property: JsonPropertyName("SalesVolume")] decimal SalesVolume
);
