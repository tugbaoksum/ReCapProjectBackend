using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity,new () //kısıtladık.
    {
        //class referans tip.
        // IEntity olabilir veya IEntity implement eden bir nesne olabilir.
        // new(): newlwnwbilir olmalı. 
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtre vermeyedebilirsin.
        T Get(Expression<Func<T, bool>> filter); //filtre zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
