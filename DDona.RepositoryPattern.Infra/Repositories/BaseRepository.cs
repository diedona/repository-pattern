using DDona.RepositoryPattern.Domain.Interfaces;
using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using DDona.RepositoryPattern.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDona.RepositoryPattern.Infra.Repositories
{
    public abstract class BaseRepository<T> : IRepositoryBase<T> where T: class, IEntity
    {
        protected readonly RepositoryPatternDbContext _db;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(RepositoryPatternDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Delete(int id)
        {
            T entity = this.GetById(id);
            this.Delete(entity);
        }

        public IList<T> Get()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Save(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _db.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
