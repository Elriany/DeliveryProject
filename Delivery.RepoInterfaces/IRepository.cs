using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Delivery.RepoInterfaces
{
    public interface IRepository<TItem> where TItem :class
    {
        TItem Get(Guid id);
        IEnumerable<TItem> GetAll();
        TItem Add(TItem item);
        IQueryable<TItem> Filter(Expression<Func<TItem, bool>> expression);

        TItem Update(TItem item);
        void Delete(Guid id);
    }
}
