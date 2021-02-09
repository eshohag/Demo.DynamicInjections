using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        #region SelfRegion
        private DbContext _context;
        private bool _disposed;

        public Repository(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            _context = context;
        }

        protected DbSet<T> DbSet
        {
            get { return _context.Set<T>(); }
        }
        #endregion
        #region IDisposable Members
        ~Repository()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_context != null)
                    {
                        _context.Dispose();
                        _context = null;
                    }
                }
            }
            _disposed = true;
        }
        #endregion

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }
        public virtual IQueryable<T> All()
        {
            return DbSet.AsQueryable().AsNoTracking();
        }
    }
}
