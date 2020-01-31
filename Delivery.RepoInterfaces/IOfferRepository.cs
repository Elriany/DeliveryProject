using Delivery.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface IOfferRepository:IRepository<Offer>
    {
         void MarkAsDeleted(Guid id);
    }
}
