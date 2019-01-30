﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcParts.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            this._logger = logger;
        }

        public void SendMessage(string to, string subject, string body)
        {
            // Log the message, but don't send it.
            _logger.LogInformation($"To: {to} Subject {subject} Body: {body}");
        }
    }
}
