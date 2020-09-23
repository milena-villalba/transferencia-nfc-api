using Domain.Transferencia.Events;
using System.Threading.Tasks;

namespace Infra.Publishers
{
    public interface IPublisher
    {
        void Publish<TEvent>(TEvent @event) where TEvent : class, IEventMessage;
        Task PublishAsync<TEvent>(TEvent @event) where TEvent : class;
    }
}
