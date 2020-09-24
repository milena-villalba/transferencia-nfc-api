using Application.Transferencia.Contracts;
using Domain.Transferencia.Commands;

namespace Application.Transferencia.Mappers
{
    public class TransferenciaMapper : ITransferenciaMapper
    {
        public Domain.Transferencia.Entities.Transferencia MapearEntidade(EnvioCommand command)
        {
            return new Domain.Transferencia.Entities.Transferencia(command.DispositivoId, command.Nome, command.Valor);
        }

        public EnvioResponse MapearEnvioResponse(Domain.Transferencia.Entities.Transferencia entidade)
        {
            return new EnvioResponse { DispositivoId = entidade.DispositivoOrigemId, Valor = entidade.Valor, Nome = entidade.Nome };
        }

        public RecebimentoResponse MapearRecebimentoResponse(Domain.Transferencia.Entities.Transferencia entidade)
        {
            return new RecebimentoResponse { NomeEmissorTransferencia = entidade.Nome, Valor = entidade.Valor, DispositivoId = entidade.DispositivoOrigemId };
        }
    }
}
