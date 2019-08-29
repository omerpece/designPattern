using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WFA_DesignPatterns.DATA.Context;

namespace WFA_DesignPatterns.RepositoryPattern
{
    public class SqlRepository<TEntity> : IRepository<TEntity, int>
        where TEntity : class
    {


        private  DataContext _context;
        protected DbSet<TEntity> _objectSet;
        public SqlRepository(WFA_DesignPatterns.DATA.Context.DataContext context)
        {
            if (_context == null)
                _context = context;
            _objectSet = context.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            //_context.Set<TEntity>().Remove(entity);
            _objectSet.Remove(entity);
        }

        public IQueryable<TEntity> FindAll()
        {
            return _objectSet;
        }

        public TEntity FindSingle(Expression<Func<TEntity, bool>> expression)
        {
            return _objectSet.FirstOrDefault(expression);
        }

        public TEntity FindSingle(int id)
        {
            return _objectSet.Find(id);
        }

        public void Insert(TEntity entity)
        {
            _objectSet.Add(entity);
        }
    }
}
