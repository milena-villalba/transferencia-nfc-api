using Application.Transferencia.Contracts;
using Application.Transferencia.Mappers;
using Domain.Transferencia.Commands;
using Domain.Transferencia.Repositories;
using System;
using System.Linq;

namespace Application.Transferencia.Services
{
    public class EnvioTransferenciaService : IEnvioTransferenciaService
    {
        private readonly ITransferenciaRepository _transferenciaRepository;
        private readonly ITransferenciaMapper _transferenciaMapper;
        public EnvioTransferenciaService(ITransferenciaRepository transferenciaRepository, ITransferenciaMapper transferenciaMapper)
        {
            _transferenciaRepository = transferenciaRepository;
            _transferenciaMapper = transferenciaMapper;
        }

        public EnvioResponse Enviar(EnvioCommand command)
        {
            var entidade = _transferenciaRepository.AddOrUpdate(_transferenciaMapper.MapearEntidade(command));
            return _transferenciaMapper.MapearEnvioResponse(entidade);
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

                return _transferenciaMapper.MapearRecebimentoResponse(entidade);
            }
            return new RecebimentoResponse();
        }
    }
}
