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
    [property: JsonPropertyName("StartingHeight")] int StartingHeight,
    [property: JsonPropertyName("StartingVolume")] int StartingVolume,
    [property: JsonPropertyName("StartingVolumeTC")] int StartingVolumeTC,
    [property: JsonPropertyName("EndingHeight")] int EndingHeight,
    [property: JsonPropertyName("EndingVolume")] int EndingVolume,
    [property: JsonPropertyName("EndingVolumeTC")] int EndingVolumeTC,
    [property: JsonPropertyName("DeliveredVolume")] int DeliveredVolume,
    [property: JsonPropertyName("DeliveredVolumeTC")] int DeliveredVolumeTC,
    [property: JsonPropertyName("StartingWaterHeight")] int StartingWaterHeight,
    [property: JsonPropertyName("StartingWaterVolume")] int StartingWaterVolume,
    [property: JsonPropertyName("EndingWaterHeight")] int EndingWaterHeight,
    [property: JsonPropertyName("EndingWaterVolume")] int EndingWaterVolume,
    [property: JsonPropertyName("StartingTemperature")] int StartingTemperature,
    [property: JsonPropertyName("EndingTemperature")] int EndingTemperature,
    [property: JsonPropertyName("SalesVolume")] int SalesVolume
);
