using System.Net.Http.Json;
using McpServerFdc.Models;

namespace McpServerFdc.Services;

public class FdcService(IHttpClientFactory httpClientFactory)
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient();
    
    public async Task<TankDeliveryResponse?> GetTankDelivery(int? deviceId)
    {
        var queryParam = deviceId.HasValue ? $"?device_id={deviceId}" : "";
        var response = await _httpClient.GetFromJsonAsync<TankDeliveryResponse>(
            $"http://192.168.100.187:5070/tank-delivery{queryParam}");
        return response;
    }
}