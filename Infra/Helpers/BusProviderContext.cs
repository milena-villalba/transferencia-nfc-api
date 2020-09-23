using EasyNetQ;

namespace Infra.Helpers
{
    public class BusProviderContext
    {
        private static IBus _busProvider;

        public static IBus BusProvider
        {
            get
            {
                return RabbitHutch.CreateBus(ProviderConfiguration.StringConnection);
            }
            set { _busProvider = value; }
        }
    }
}
