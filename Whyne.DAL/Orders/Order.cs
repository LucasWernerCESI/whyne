using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.Products;

namespace Whyne.DAL.Orders
{
    public abstract class Order
    {
        public int Id { get; set; }
        public List<OrderLine>? OrderLines { get; set; }
        public DateTime Created { get; set; }
    }
}