using System;

namespace Domain.Transferencia.Entities
{
    public class Transferencia : EntityBase
    {
        public Guid DispositivoOrigemId { get; set; }
        public Guid? DispositivoDestinoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Ativa { get; set; }

        public Transferencia(Guid dispositivoOrigemId, string nome, decimal valor)
        {
            DispositivoOrigemId = dispositivoOrigemId;
            Nome = nome;
            Valor = valor;
            Ativar();
        }

        public void Ativar() => Ativa = true;
        public void Desativar() => Ativa = false;

        public Transferencia SetDispositivoDestino(Guid dispositivoDestinoId)
        {
            DispositivoDestinoId = dispositivoDestinoId;
            return this;
        }
    }
}
