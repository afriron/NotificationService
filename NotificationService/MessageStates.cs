namespace NotificationService
{
    /// <summary>
    /// Состояния сообщения
    /// </summary>
    public enum MessageStates
    {
        /// <summary>
        /// Новое
        /// </summary>
        /// <remarks>
        /// Сообщение было получено сервисом, но еще не поставлено в очередь отправки
        /// </remarks>
        New,

        /// <summary>
        /// Поставлено в очередь
        /// </summary>
        /// <remarks>
        /// Сообщение подготовлено к отправке, но еще не отправлено
        /// </remarks>
        InQueue,

        /// <summary>
        /// Передаётся
        /// </summary>
        /// <remarks>
        /// Сообщение в процессе передачи получателю
        /// </remarks>
        Transmitted,

        /// <summary>
        /// Отправлено
        /// </summary>
        /// <remarks>
        /// Сообщение отправлено без ошибок
        /// </remarks>
        Sent,

        /// <summary>
        /// Ошибка обработки
        /// </summary>
        ProcessingError,

        /// <summary>
        /// Ошибка отправки
        /// </summary>
        SendingError
    }
}
