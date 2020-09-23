using Application.Transferencia.Contracts;
using Domain.Transferencia.Commands;
using Domain.Transferencia.Repositories;
using System;
using System.Linq;

namespace Application.Transferencia.Services
{
    public class EnvioTransferenciaService : IEnvioTransferenciaService
    {
        private readonly ITransferenciaRepository _transferenciaRepository;
        public EnvioTransferenciaService(ITransferenciaRepository transferenciaRepository)
        {
            _transferenciaRepository = transferenciaRepository;
        }

        public EnvioResponse Enviar(EnvioCommand command)
        {
            var entidade = new Domain.Transferencia.Entities.Transferencia(command.DispositivoId, command.Nome, command.Valor);
            var entidadeSalva = _transferenciaRepository.AddOrUpdate(entidade);
            return new EnvioResponse { DispositivoId = entidadeSalva.DispositivoOrigemId, Valor = entidadeSalva.Valor, Nome = entidadeSalva.Nome};
        }

        public RecebimentoResponse Receber(Guid dispositivoId)
        {
            var entidade = _transferenciaRepository.GetAll()
                .Where(p => p.Ativa).AsEnumerable().LastOrDefault();
            if(entidade != null)
            {
                entidade.SetDispositivoDestino(dispositivoId);
                entidade.Desativar();
                _transferenciaRepository.AddOrUpdate(entidade);

                return new RecebimentoResponse { NomeEmissorTransferencia = entidade.Nome, Valor = entidade.Valor, DispositivoId = entidade.DispositivoOrigemId };
            }
            return new RecebimentoResponse();
        }
    }
}
