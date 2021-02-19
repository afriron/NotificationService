using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.Models
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Идентификатор сообщения
        /// </summary>
        public Guid MessageId { get; set; }

        /// <summary>
        /// Время добавления сообщения
        /// </summary>
        public long AddTime { get; set; }
       
        /// <summary>
        /// Время отправки сообщения
        /// </summary>
        public long? SendTime { get; set; }

        /// <summary>
        /// Состояние обработки
        /// </summary>
        public MessageStates State { get; set; }

        /// <summary>
        /// Содержимое сообщения
        /// </summary>
        public string Content { get; set; }
    }
}
