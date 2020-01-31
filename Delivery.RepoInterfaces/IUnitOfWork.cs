using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void Dispose();
    }
}
