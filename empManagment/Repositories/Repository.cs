using empManagment.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace empManagment.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly clsAppDBContext _dbcontext;
        private readonly DbSet<T> _dbset;

        public Repository(clsAppDBContext dBContext)
        {
            _dbcontext = dBContext;
            _dbset=_dbcontext.Set<T>();
        }

        public void Add(T item)
        {
            _dbset.Add(item);
            
        }

        public T? Get(Expression<Func<T, bool>> filter)
        {
            return _dbset.FirstOrDefault(filter);
        }
        public T? Get(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbset;
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return query.FirstOrDefault(filter);
        }

        public IEnumerable<T> GetAll()
        {
           return _dbset.ToList();
        }

        public void Remove(T item)
        {
            _dbset.Remove(item);
           
        }

        public void Update(T item)
        {
            _dbset.Update(item);
            
        }

        public void Save()
        {
            _dbcontext.SaveChanges();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbset;
            foreach (var item in includes) 
            {
                query=query.Include(item);
            }
            return query.ToList();
        }

        public IEnumerable<T> GetAll(int PageSize, int PageNumber, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbset;
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return query.Skip((PageNumber-1)*PageSize).Take(PageSize).ToList();
        }

        public int Count()
        {
            return _dbset.Count();
        }
    }
}
