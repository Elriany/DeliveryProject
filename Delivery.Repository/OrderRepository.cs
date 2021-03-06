﻿using Delivery.Core;
using Delivery.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public void MarkAsDeleted(Guid id)
        {
            Get(id).IsDeleted = true;
        }
    }
}
