﻿using Delivery.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface IUserRepository:IRepository<User>
    {
        void MarkAsDeleted(Guid id);
    }
}
