using System;
using Delivery.Core;
using System.Collections.Generic;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface IDeliveryRepository: IRepository<Delivery.Core.Delivery>
    {
         void MarkAsDeleted(Guid id);
    }
}
