using System.Threading;
using System.Threading.Tasks;
using NotificationService.Models;

namespace NotificationService.Providers
{
    /// <summary>
    /// Провайдер отправки сообщений для конкретного канала доставки
    /// </summary>
    public interface IMessageProvider
    {
        /// <summary>
        /// Канал доставки, который обслуживает данный провайдер
        /// </summary>
        NotificationChannel Channel { get; }

        /// <summary>
        /// Отправить сообщение получателю
        /// </summary>
        Task<ProviderSendResult> SendAsync(Message message, CancellationToken cancellationToken = default);
    }
}
