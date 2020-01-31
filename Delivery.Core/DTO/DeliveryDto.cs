using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Core.DTO
{
    public class DeliveryDto
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
    }
}
