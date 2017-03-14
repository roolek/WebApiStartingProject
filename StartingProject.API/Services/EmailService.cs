using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace StartingProject.API.Services
{
    public class EmailService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(message.Destination);
            mailMessage.From = new MailAddress("YOUR_MAIL");
            mailMessage.Subject = message.Subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = message.Body;
            SmtpClient smtpClient = new SmtpClient("YOUR_SMTP_SERVER");
            smtpClient.Credentials = new NetworkCredential("YOUR_USERNAME", "YOUR_PASSWORD");
            await smtpClient.SendMailAsync(mailMessage); 
        }

     
    }
}