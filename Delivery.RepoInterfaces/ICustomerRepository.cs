using Delivery.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public void MarkAsDeleted(Guid id);
    }
}
