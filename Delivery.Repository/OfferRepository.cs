using Delivery.Core;
using Delivery.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Repository
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        public OfferRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public void MarkAsDeleted(Guid id)
        {
            Get(id).IsDeleted = true;
        }
    }
}
