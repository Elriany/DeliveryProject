using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Core
{
    public class Delivery
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte Review { get; set; }
        public bool IsDeleted { get; set; }
        public double Dept { get; set; }
        public bool IsActive { get; set; }
        public bool IsFree { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Attendance> Attendances { get; set; }
    }
}
