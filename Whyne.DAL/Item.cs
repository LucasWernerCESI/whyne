using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Whyne.DAL
{
    public class Item
    {
        [Required] public int ItemId { get; set; }

        [Required] public string? Icon { get; set; }
        [MaxLength(150)] [Required] public string? Title { get; set; }
        [Required] public string? Description { get; set; }
        [Required] public float? DegreeAlcoolo { get; set; }
        [MaxLength(150)] [Required] public string? Familly { get; set; }
        [Required] public int? Quantity { get; set; }
        [MaxLength(150)] [Required] public string? Provider { get; set; }
        [Required] public float? Price { get; set; }
    }
}
