using Siparis.Models;
using System.Collections.Generic;

namespace Siparis.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
