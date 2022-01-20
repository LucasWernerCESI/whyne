using System.Text.Json.Serialization;

namespace App.Model
{
    class Item
{
        [JsonPropertyName("id")]  public int Id { get; set; } //ID unique
        [JsonPropertyName("icon")] public string? Icon { get; set; } //icon
        [JsonPropertyName("title")]  public string? Title { get; set; } //nom: Chateauneuf du croix 2002
        [JsonPropertyName("description")] public string? Description { get; set; } //description: Vin de qualité à la robe douce et fruitée... Médaille d'argent grand prix truc
        [JsonPropertyName("degreealcoolo")] public int? DegreeAlcoolo { get; set; } //°
        [JsonPropertyName("familly")]  public string? Familly { get; set; } //type: vin rouge, vin blanc,  champagne, rosé...
        [JsonPropertyName("quantity")] public int? Quantity { get; set; } //quantité
        [JsonPropertyName("provider")] public string? Provider { get; set; } //producteur/revendeur
        [JsonPropertyName("price")] public float? Price { get; set; } //prix
    }
}
