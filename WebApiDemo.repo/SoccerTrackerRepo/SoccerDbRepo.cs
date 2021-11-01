using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiDemo.Data;

namespace WebApiDemo.repo
{
    public class SoccerDbRepo<T> : IRepo<T> where T : class
    {
        private readonly SoccerTrackerDbEntities context;
        private DbSet<T> entities;

        public SoccerDbRepo(SoccerTrackerDbEntities context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T Get(long id)
        {
            return entities.Find(id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(long id, T entity)
        {
            
            
            context.Entry(entity).State = EntityState.Modified;
            
            context.SaveChanges();
        }

        public void Delete(long id)
        {
            T entity = Get(id);
            entities.Remove(entity);
            context.SaveChanges();
        }

        
    }
}