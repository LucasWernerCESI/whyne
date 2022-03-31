using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whyne.DAL.Orders;
using Whyne.Models.People;

namespace Whyne.DAL.People
{
    public class Customer : Person
    {
        public List<CustomerOrder>? Orders { get; set; }
    }
}