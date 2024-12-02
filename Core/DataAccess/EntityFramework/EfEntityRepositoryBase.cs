using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    //TEntity : Veritabanında bir tabloya karşılık gelecek olan model bir class olacak
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() 
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //Aşağıdaki using ifadesi "IDispossable pattern implementation of C#" konusudur.
            //İçerisinde belirtilen kaynak işi bitince bellekten hemen atılır. 
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);   //Referansı yakala
                addedEntity.State = EntityState.Added;     //Bu eklenecek bir nesnedir.
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);   //Referansı yakala
                deletedEntity.State = EntityState.Deleted;     //Bu silinecek bir nesnedir.
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);   //Referansı yakala
                updatedEntity.State = EntityState.Modified;     //Bu güncellenecek bir nesnedir.
                context.SaveChanges();
            }
        }
    }
}
