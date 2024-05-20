using Microsoft.EntityFrameworkCore;
using Odysseycs.Application.Interfaces;
using Odysseycs.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Odysseycs.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IUniversityDbContext _dbContext;

        public Repository(IUniversityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
        public T GetById(long id)
        {
            return _dbContext.Set<T>().Find(id);
        }
        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
        }
    }
}

