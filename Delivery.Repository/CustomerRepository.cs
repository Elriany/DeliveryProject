using Delivery.Core;
using Delivery.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Repository
{
    public class CustomerRepository : Repository<Customer> , ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext):base(dbContext)
        {
        }
        public void MarkAsDeleted(Guid id)
        {
            Get(id).IsDeleted = true;
        }
    }
}
