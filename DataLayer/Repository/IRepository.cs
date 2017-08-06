using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DataLayer.Repository
{
    public interface IRepository<T> : IDisposable where T : IEntity
    {
        IQueryable<T> GetAll();
        void Delete(T entity);
        void Add(T entity);
    }

    public interface IEntity
    {
        int Id { get; set; }
    }
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();
    }
}
