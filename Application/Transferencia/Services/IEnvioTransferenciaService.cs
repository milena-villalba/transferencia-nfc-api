using Application.Transferencia.Contracts;
using Domain.Transferencia.Commands;
using System;

namespace Application.Transferencia.Services
{
    public interface IEnvioTransferenciaService
    {
        EnvioResponse Enviar(EnvioCommand command);
        RecebimentoResponse Receber(Guid dispositivoId);
    }
}
