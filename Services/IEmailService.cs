using Azure.Messaging.ServiceBus;
using EmailProviderNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProviderNew.Services;

public interface IEmailService
{
    bool SendEmail(EmailRequest emailRequest);
    EmailRequest UnpackEmailRequest(ServiceBusReceivedMessage message);
}
