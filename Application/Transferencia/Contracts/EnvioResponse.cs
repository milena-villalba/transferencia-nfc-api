using System;

namespace Application.Transferencia.Contracts
{
    public class EnvioResponse
    {
        public Guid DispositivoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
