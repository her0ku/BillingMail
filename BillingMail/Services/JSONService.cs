using System.Text.Json;

namespace BillingMail.Services
{
    public class JSONService : IJSONService
    {
        public T Deserialize<T>(string json)
        {
            JsonSerializerOptions option = new JsonSerializerOptions 
            {  
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase 
            };
            
            return JsonSerializer.Deserialize<T>(json, option);
        }

        public string Serialize<T>(T data)
        {
            return JsonSerializer.Serialize(data);
        }
    }
}
