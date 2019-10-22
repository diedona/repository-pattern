using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.RepositoryPattern.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T: IEntity
    {
        IList<T> Get();
        T GetById(int id);
        void Save(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
