using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotificationService.Models;

namespace NotificationService.Services
{
    public interface IMessageQueue
    {
        Task<Guid> Add(Message message);
    }
}
