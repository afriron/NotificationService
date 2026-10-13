using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NotificationService.Models;

namespace NotificationService.Providers
{
    /// <summary>
    /// Отправка сообщений по SMS
    /// </summary>
    class SmsMessageProvider : IMessageProvider
    {
        private readonly ILogger<SmsMessageProvider> _logger;

        public NotificationChannel Channel => NotificationChannel.Sms;

        public SmsMessageProvider(ILogger<SmsMessageProvider> logger)
        {
            _logger = logger;
        }

        public Task<ProviderSendResult> SendAsync(Message message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
