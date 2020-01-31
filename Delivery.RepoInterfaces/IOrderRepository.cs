using Delivery.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface IOrderRepository:IRepository<Order>
    {
        void MarkAsDeleted(Guid id);
    }
}
