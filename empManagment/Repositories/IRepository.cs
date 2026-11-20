using System.Linq.Expressions;

namespace empManagment.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T>GetAll(params  Expression<Func<T, object>> []includes);
        IEnumerable<T> GetAll(int PageSize,int PageNumber,params Expression<Func<T, object>>[] includes);
        void Add(T item);
        
        void Update(T item);
        void Remove(T item);
        void Save();
        int Count();
        T? Get(Expression<Func<T, bool>> filter);
        T? Get(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);

    }
}
