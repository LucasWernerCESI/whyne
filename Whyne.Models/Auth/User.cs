using System.Text.Json.Serialization;

namespace Whyne.Models
{
    public class User
    {
        [JsonPropertyName("email")] public string Email { get; set; }
        [JsonPropertyName("userName")] public string UserName { get; set; }
        [JsonPropertyName("phoneNumber")] public string PhoneNumber { get; set; }
    }
}