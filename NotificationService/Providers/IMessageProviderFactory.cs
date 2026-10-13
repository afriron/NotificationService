using NotificationService.Models;

namespace NotificationService.Providers
{
    /// <summary>
    /// Фабрика провайдеров отправки сообщений
    /// </summary>
    public interface IMessageProviderFactory
    {
        /// <summary>
        /// Получить провайдер, обслуживающий указанный канал доставки
        /// </summary>
        /// <exception cref="ProviderNotFoundException">
        /// Для указанного канала не зарегистрирован ни один провайдер
        /// </exception>
        IMessageProvider GetProvider(NotificationChannel channel);
    }
}
