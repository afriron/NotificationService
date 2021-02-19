using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotificationService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipientController : ControllerBase
    {
        private readonly ILogger<RecipientController> _logger;
        private readonly IMessageQueue _messageQueue;
        public RecipientController(IMessageQueue messageQueue, ILogger<RecipientController> logger)
        {
            _messageQueue = messageQueue;
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Take()
        {

            return Ok();
        }
    }
}
