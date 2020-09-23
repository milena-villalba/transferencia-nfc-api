using Application.Transferencia.Contracts;
using Domain.Transferencia.Commands;
using Domain.Transferencia.Events;
using Infra.Publishers;
using System;

namespace Application.Transferencia.Services
{
    public class EnvioTransferenciaService : IEnvioTransferenciaService
    {
        private readonly IPublisher _publisher;
        public EnvioTransferenciaService(IPublisher publisher)
        {
            _publisher = publisher;
        }

        public EnvioResponse Enviar(EnvioCommand command)
        {
            _publisher.Publish(new TransferenciaEvent { MessageId = Guid.NewGuid(), DispositivoId = command.DispositivoId, Valor = command.Valor });
            return new EnvioResponse { DispositivoId = command.DispositivoId, Valor = command.Valor} ;
        }
    }
}
