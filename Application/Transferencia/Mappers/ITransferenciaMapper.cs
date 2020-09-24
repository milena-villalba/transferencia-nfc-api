using Application.Transferencia.Contracts;
using Domain.Transferencia.Commands;

namespace Application.Transferencia.Mappers
{
    public interface ITransferenciaMapper
    {
        RecebimentoResponse MapearRecebimentoResponse(Domain.Transferencia.Entities.Transferencia entidade);
        EnvioResponse MapearEnvioResponse(Domain.Transferencia.Entities.Transferencia entidade);
        Domain.Transferencia.Entities.Transferencia MapearEntidade(EnvioCommand command);
    }
}
