using Microsoft.Extensions.DependencyInjection.DynamicInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Demo.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        IQueryable<T> All();
    }
}
