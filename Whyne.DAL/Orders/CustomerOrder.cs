using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.People;

namespace Whyne.DAL.Orders
{
    public class CustomerOrder : Order
    {
        public Customer Customer { get; set; }
        public Distributor Distributor { get; set; }
        public Adress BillingAdress { get; set; }
        public Adress DeliveryAdress { get; set; }
    }
}