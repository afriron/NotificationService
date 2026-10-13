using System.Collections.Generic;
using System.Linq;
using NotificationService.Models;

namespace NotificationService.Providers
{
    class MessageProviderFactory : IMessageProviderFactory
    {
        private readonly Dictionary<NotificationChannel, IMessageProvider> _providers;

        public MessageProviderFactory(IEnumerable<IMessageProvider> providers)
        {
            _providers = providers.ToDictionary(provider => provider.Channel);
        }

        public IMessageProvider GetProvider(NotificationChannel channel)
        {
            if (!_providers.TryGetValue(channel, out var provider))
            {
                throw new ProviderNotFoundException(channel);
            }

            return provider;
        }
    }
}
