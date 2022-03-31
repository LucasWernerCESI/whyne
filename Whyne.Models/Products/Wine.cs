using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Whyne.Enum;
using Whyne.Models.People;

namespace Whyne.Models.Products
{
    public class Wine : Product
    {
        [JsonPropertyName("hasBubbles")] public bool HasBubbles { get; set; }
        [JsonPropertyName("color")] public WineColor Color { get; set; }
        [JsonPropertyName("sugarResidues")] public float? SugarResidues { get; set; }
        [JsonPropertyName("acidity")] public float? Acidity { get; set; }
        [JsonPropertyName("tannins")] public float? Tannins { get; set; }
        [JsonPropertyName("alcohol")] public float Alcohol { get; set; }
        [JsonPropertyName("grapeVariety")] public string? GrapeVariety { get; set; }
        [JsonPropertyName("region")] public string? Region { get; set; }
        [JsonPropertyName("vintage")] public int? Vintage { get; set; }
        [JsonPropertyName("taxFreeUnitPrice")] public float? TaxFreeUnitPrice { get; set; }
    }
}