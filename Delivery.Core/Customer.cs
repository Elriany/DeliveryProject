using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Core
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public bool Blocked { get; set; }
        public bool IsDeleted { get; set; }
        public string BlockReason { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
