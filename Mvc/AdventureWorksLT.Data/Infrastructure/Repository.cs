using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;

namespace AdventureWorksLT.Data.Infrastructure
{
    public partial class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDatabaseFactory _databaseFactory;
        private readonly IDbSet<T> _dbset;
        public Repository(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _dbset = _databaseFactory.Context.Set<T>();
        }

        public virtual void Insert(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbset.Attach(entity);
            _databaseFactory.Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> objects = _dbset.Where<T>(predicate).AsQueryable();
            foreach (T obj in objects)
                _dbset.Remove(obj);
        }

        public virtual int Count
        {
            get { return _dbset.Count(); }
        }

        public virtual bool Contains(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Count(predicate) > 0;
        }

        public virtual T Find(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).FirstOrDefault<T>();
        }

        public virtual T Find(params object[] keys)
        {
            return _dbset.Find(keys);
        }

        public virtual T Find(object id)
        {
            return _dbset.Find(id);
        }

        public virtual IQueryable<T> Filter(Expression<Func<T, bool>> where)
        {
            return _dbset.Where(where);
        }

        public IQueryable<T> Filter<TKey>(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50)
        {
            int skipCount = index * size;
            var resetSet = filter != null ? _dbset.Where(filter).AsQueryable() : _dbset.AsQueryable();
            resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.Skip(skipCount).Take(size);
            total = resetSet.Count();
            return resetSet.AsQueryable();
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return _dbset;
            }
        }
    }
}
