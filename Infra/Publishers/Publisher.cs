using Domain.Transferencia.Events;
using EasyNetQ;
using Infra.Helpers;
using Infra.Messaging;
using System;
using System.Threading.Tasks;

namespace Infra.Publishers
{
    public class Publisher : IPublisher
    {
        public void Publish<TEvent>(TEvent @event) where TEvent : class, IEventMessage
        {
            var properties = new MessageProperties() { DeliveryMode = 2 };
            var envelope = new ContentMessage(@event);
            var message = new Message<ContentMessage>(envelope, properties);
            var bus = RabbitHutch.CreateBus(ProviderConfiguration.StringConnection);
            bus.Publish(message);
        }

        public Task PublishAsync<TEvent>(TEvent @event) where TEvent : class
        {
            throw new NotImplementedException();
        }
    }
}
