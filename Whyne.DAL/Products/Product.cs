using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.People;

namespace Whyne.DAL.Products
{
    abstract public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StoredAmount { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
