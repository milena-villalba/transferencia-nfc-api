using System;

namespace Domain.Transferencia.Events
{
    public class TransferenciaEvent : IEventMessage
    {
        public Guid MessageId { get; set; }
        public string DispositivoId { get; set; }
        public decimal Valor { get; set; }
    }
}
