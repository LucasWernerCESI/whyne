using System.Text.Json.Serialization;

namespace App.Model
{
    class Provider
{
        [JsonPropertyName("id")] public int Id { get; set; } //ID unique
        [JsonPropertyName("name")] public string? Name { get; set; } //nom productueur/marque
        [JsonPropertyName("location")] public string? Location { get; set; } //adresse/géolocalisation
        [JsonPropertyName("product")] public string? Product { get; set; } //liste des produits
    }
}
