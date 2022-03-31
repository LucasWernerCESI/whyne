using System.Text.Json.Serialization;

namespace Whyne.Models
{
    public class Account
    {
        [JsonPropertyName("email")] public string Email { get; set; }
        [JsonPropertyName("userName")] public string UserName { get; set; }
        [JsonPropertyName("password")] public string Password { get; set; }
    }
}