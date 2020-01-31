using Delivery.Core;
using Delivery.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public void MarkAsDeleted(Guid id)
        {
            Get(id).IsDeleted = true;
        }
    }
}
