using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class EmailSender
    {
        public void SendEmail(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class NotificationService
    {
        private readonly EmailSender _emailSender;

        public NotificationService()
        {
            _emailSender = new EmailSender(); // Dependencia concreta
        }

        public void SendNotification(string recipient, string message)
        {
            _emailSender.SendEmail(recipient, message);
        }
    }

}
