using System.Linq;

namespace Domain.Transferencia.Repositories
{
    public interface IRepository<TEntity> where TEntity: Entities.EntityBase
    {
        TEntity AddOrUpdate(TEntity entity);
        IQueryable<TEntity> GetAll();
    }
}
