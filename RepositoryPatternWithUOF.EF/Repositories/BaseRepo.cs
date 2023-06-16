using Microsoft.EntityFrameworkCore;
using RepositoryPatternUOW.Core.interfaces;
using System.Linq.Expressions;

namespace RepositoryPatternWithUOF.EF.Repositories
{
    public class BaseRepo<T>: IBaseRepo<T> where T:class
    {
        private readonly ApplicationDBContext _context;
        public BaseRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public T Find(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if(includes != null)
                foreach (var incluse in includes)
                    query = query.Include(incluse);

            return query.SingleOrDefault(match);
        }
       //null err
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
                foreach (var incluse in includes)
                    query = query.Include(incluse);

            return query.Where(match).ToList();
        }
        /*public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (includes != null)
                foreach (var incluse in includes)
                    query = query.Include(incluse);

            return query.Where(match).ToList();
        }*/
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return entity;
        }
        public IEnumerable<T> AddRange(IEnumerable<T> entities) 
        {
            _context.Set<T>().AddRange(entities);
            _context.SaveChanges();

            return entities;
        }

        
    }
}
