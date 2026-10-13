using System;
using NotificationService.Models;

namespace NotificationService.Providers
{
    /// <summary>
    /// Исключение, возникающее при отсутствии провайдера для запрошенного канала доставки
    /// </summary>
    public class ProviderNotFoundException : Exception
    {
        public NotificationChannel Channel { get; }

        public ProviderNotFoundException(NotificationChannel channel)
            : base($"Провайдер для канала '{channel}' не зарегистрирован")
        {
            Channel = channel;
        }
    }
}
