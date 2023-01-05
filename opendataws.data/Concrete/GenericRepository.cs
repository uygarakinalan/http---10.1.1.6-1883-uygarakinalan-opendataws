using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using opendataws.data.Abstract;

namespace opendataws.data.Concrete
{
    public class GenericRepository<TEntity, TDbContext> : IGenericRepository<TEntity>
    where TEntity : class
    where TDbContext : DbContext, new()
    {
        public TEntity Create(TEntity entity)
        {
            using (var context = new TDbContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(int id)
        {
            using (var context = new TDbContext())
            {
                context.Set<TEntity>().Remove(GetById(id));
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TDbContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TDbContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TDbContext())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}


