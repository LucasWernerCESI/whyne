using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.Orders;

namespace Whyne.DAL.People
{
    public class Supplier: Corporation
    {
        public List<SupplierOrder> SupplierOrders { get; set; }
    }
}
