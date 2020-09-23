using Domain.Transferencia.Events;

namespace Infra.Messaging
{
    public class ContentMessage
    {
        IEventMessage Content { get; set; }
        public ContentMessage(IEventMessage message)
        {
            this.Content = message;
        }
    }
}
