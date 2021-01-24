using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.EmailSettings
{
    public class EmailSender : IEmailSender
    {
        private const string SendGridKey = "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";
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(SendGridKey, subject, htmlMessage, email);
        }
        private Task Execute(string sendGridKey, string subject, string message, string email)
        {
            var client = new SendGridClient(sendGridKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("info@shopapp.com", "Shop App"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(new EmailAddress(email));
            return client.SendEmailAsync(msg);
        }
    }
}
