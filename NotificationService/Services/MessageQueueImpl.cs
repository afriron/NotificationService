using NotificationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.Services
{
    class MessageQueueImpl : IMessageQueue
    {
        public Task<Guid> Add(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
