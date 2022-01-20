using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Whyne.DAL
{
    public class Provider
    {
        [Required] public int ProviderId { get; set; }
        [MaxLength(150)] [Required] public string Name { get; set; }
        [MaxLength(150)] [Required] public string Location { get; set; }
        [Required] public string Product { get; set; }

    }
}
