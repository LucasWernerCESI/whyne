using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Whyne.Models.People
{
    public abstract class Person
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("firstName")] public string FirstName { get; set; }
        [JsonPropertyName("lastName")] public string LastName { get; set; }
        [JsonPropertyName("email")] public string Email { get; set; }
        [JsonPropertyName("phoneNumber")] public string PhoneNumber { get; set; }
        [JsonPropertyName("adresses")] public List<Adress>? Adresses { get; set; }
    }
}
