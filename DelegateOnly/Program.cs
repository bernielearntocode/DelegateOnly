using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            Action<Message> notificationHandler = new MailNotificationChannel().Send;
            notificationHandler += new SmsNotificationChannel().Send;
            encoder.Encode(new Video(), notificationHandler);
        }
    }
}
