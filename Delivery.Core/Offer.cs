using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Core
{
    public class Offer
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
