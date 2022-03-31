using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Whyne.Models.People
{
    public abstract class Corporation
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("registrationNumber")] public string RegistrationNumber { get; set; }
        [JsonPropertyName("taxNumber")] public string TaxNumber { get; set; }
    }
}
