using Application.Transferencia.Contracts;
using Domain.Transferencia.Commands;

namespace Application.Transferencia.Services
{
    public interface IEnvioTransferenciaService
    {
        EnvioResponse Enviar(EnvioCommand command);
    }
}
