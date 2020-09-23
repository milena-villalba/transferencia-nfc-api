using System;

namespace Domain.Transferencia.Commands
{
    public class EnvioCommand
    {
        public Guid DispositivoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
