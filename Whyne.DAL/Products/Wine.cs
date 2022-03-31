using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.People;
using Whyne.Enum;

namespace Whyne.DAL.Products
{
    public class Wine : Product
    {
        public bool HasBubbles { get; set; }
        public WineColor Color { get; set; }
        public float? SugarResidues { get; set; }
        public float? Acidity { get; set; }
        public float? Tannins { get; set; }
        public float Alcohol { get; set; }
        public string? GrapeVariety { get; set; }
        public string? Region { get; set; }
        public int? Vintage { get; set; }
        public float? TaxFreeUnitPrice { get; set; }
        
    }
}
