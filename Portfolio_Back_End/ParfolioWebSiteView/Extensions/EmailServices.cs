using System;
using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace ParfolioWebSiteView.Extensions
{

    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }

    public class EmailServices : IEmailService
    {
        public void Send(string to, string subject, string html)
        {
            //create messenge
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("templatemail24@gmail.com"));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text=html};

            //Send Email
            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com",587, SecureSocketOptions.StartTls);
            smtp.Authenticate("templatemail24@gmail.com", "**********************");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
