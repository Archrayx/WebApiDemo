using System.Collections.Generic;

namespace WebApiDemo.repo
{
    public interface IRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(long id, T entity);
        void Delete(long id);
        
    }
}