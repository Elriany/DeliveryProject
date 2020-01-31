using Delivery.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Delivery.Repository
{
    public class Repository<TItem> : IRepository<TItem> where TItem : class
    {
        private readonly DbContext _dbContext;
        public DbSet<TItem> _itemSet{ get; set; }

        public Repository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            _itemSet = _dbContext.Set<TItem>();
        }
        public TItem Add(TItem item)
        {
            return _itemSet.Add(item).Entity;
        }

        public void Delete(Guid id)
        {
            var entity = Get(id);
            _itemSet.Remove(entity);
        }

        public IQueryable<TItem> Filter(Expression<Func<TItem, bool>> expression)
        {
            return _itemSet.Where(expression);
        }

        public TItem Get(Guid id)
        {
            return _itemSet.Find(id);
        }

        public IEnumerable<TItem> GetAll()
        {
            return _itemSet.ToList();
        }

        public TItem Update(TItem item)
        {
            _dbContext.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
