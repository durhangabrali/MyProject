using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Bu interface ilk olarak DataAccess>Abstract  klasöründe oluşturuldu. Daha sonra buraya taşındı.
    //Generic Constraint
    //class : referans tip olmalı anlamındadır.
    //IEntity : Buradaki T ya referans tip olmalı ve IEntity veya IEntity'den implemente bir referans olmalı. 
    //new() : Eğer new() şartı da eklersek, sadece IEntity'den new'lenebilen bir Nesne referansı olabilir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);      
    }
}
