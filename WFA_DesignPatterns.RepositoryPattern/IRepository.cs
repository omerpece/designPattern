using System;
using System.Linq;
using System.Linq.Expressions;

namespace WFA_DesignPatterns.RepositoryPattern
{
    public interface IRepository<TEntity, TId>
        where TEntity : class
            where TId : struct
    {
        IQueryable<TEntity> FindAll();
        TEntity FindSingle(Expression<Func<TEntity, bool>> expression);
        TEntity FindSingle(TId id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
    }
}
