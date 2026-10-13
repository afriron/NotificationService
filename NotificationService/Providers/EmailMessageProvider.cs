using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NotificationService.Models;

namespace NotificationService.Providers
{
    /// <summary>
    /// Отправка сообщений по электронной почте
    /// </summary>
    class EmailMessageProvider : IMessageProvider
    {
        private readonly ILogger<EmailMessageProvider> _logger;

        public NotificationChannel Channel => NotificationChannel.Email;

        public EmailMessageProvider(ILogger<EmailMessageProvider> logger)
        {
            _logger = logger;
        }

        public Task<ProviderSendResult> SendAsync(Message message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
