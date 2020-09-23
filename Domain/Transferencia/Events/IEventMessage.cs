using System;

namespace Domain.Transferencia.Events
{
    public interface IEventMessage
    {
        Guid MessageId { get; set; }
    }
}
