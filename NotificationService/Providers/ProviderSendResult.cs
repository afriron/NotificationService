namespace NotificationService.Providers
{
    /// <summary>
    /// Результат отправки сообщения провайдером
    /// </summary>
    public class ProviderSendResult
    {
        /// <summary>
        /// Признак успешной отправки
        /// </summary>
        public bool Success { get; }

        /// <summary>
        /// Описание ошибки, если отправка не удалась
        /// </summary>
        public string ErrorMessage { get; }

        private ProviderSendResult(bool success, string errorMessage)
        {
            Success = success;
            ErrorMessage = errorMessage;
        }

        public static ProviderSendResult Ok() => new ProviderSendResult(true, null);

        public static ProviderSendResult Fail(string errorMessage) => new ProviderSendResult(false, errorMessage);
    }
}
