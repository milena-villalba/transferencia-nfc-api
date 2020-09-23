using Domain.Transferencia.Entities;
using Domain.Transferencia.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;

namespace Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly TransferenciaContext _context;
        public RepositoryBase(TransferenciaContext context)
        {
            _context = context;
        }

        public TEntity AddOrUpdate(TEntity entity)
        {
            EntityEntry<TEntity> entry;
            if (entity.Id == null)
            {
                entry = Insert(entity);
            }
            else
            {
                entry = this.Update(entity);
            }

            _context.SaveChanges();
            return entry.Entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        private EntityEntry<TEntity> Insert(TEntity entity)
        {
            return _context.Set<TEntity>().Add(entity);
        }

        private EntityEntry<TEntity> Update(TEntity entity)
        {
            var localEntity = _context.Set<TEntity>().Local.Any(x => x.Id.Equals(entity.Id));
            EntityEntry<TEntity> entry = null;
            if (localEntity)
            {
                var objToUpdate = _context.Set<TEntity>().Find(entity.Id);
                entry = _context.Entry(objToUpdate);
                entry.CurrentValues.SetValues(entity);
                entry.State = EntityState.Modified;
            }
            else
            {
                entry = _context.Set<TEntity>().Update(entity);
            }
            return entry;
        }
    }
}
