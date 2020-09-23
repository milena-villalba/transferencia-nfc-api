using System;

namespace Application.Transferencia.Contracts
{
    public class RecebimentoResponse
    {
        public Guid DispositivoId { get; set; }
        public string NomeEmissorTransferencia { get; set; }
        public decimal Valor { get; set; }
    }
}
