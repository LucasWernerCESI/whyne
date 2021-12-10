using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Model
{
    public class Account
    {
        [JsonPropertyName("accountId")] public int AccountId { get; set; }

        [JsonPropertyName("title")] public string Title { get; set; }

        [JsonPropertyName("firstName")] public string FirstName { get; set; }

        [JsonPropertyName("lastName")] public string LastName { get; set; }

        [JsonPropertyName("email")] public string Email { get; set; }

        [JsonPropertyName("role")] public string Role { get; set; }

        [JsonPropertyName("createdAt")] public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")] public DateTime? UpdatedAt { get; set; }
    }
}
