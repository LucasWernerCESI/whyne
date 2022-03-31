using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.People;

namespace Whyne.DAL.Orders
{
    public class SupplierOrder : Order
    {
        public Supplier Supplier { get; set; }
    }
}