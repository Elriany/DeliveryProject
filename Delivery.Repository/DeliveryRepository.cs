using Delivery.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delivery.Repository
{
    public class DeliveryRepository : Repository<Delivery.Core.Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public void MarkAsDeleted(Guid id)
        {
            Get(id).IsDeleted = true;
        }

       
    }
}
