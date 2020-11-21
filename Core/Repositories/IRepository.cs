using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Knights.Repositories
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        //for finding objs
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //for adding objs
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //for removing objs
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
