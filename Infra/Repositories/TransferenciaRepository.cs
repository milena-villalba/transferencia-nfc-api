using Domain.Transferencia.Entities;
using Domain.Transferencia.Repositories;
using Infra.Context;

namespace Infra.Repositories
{
    public class TransferenciaRepository : RepositoryBase<Transferencia>, ITransferenciaRepository
    {
        public TransferenciaRepository(TransferenciaContext context) : base(context)
        {
        }
    }
}
