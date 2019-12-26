using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateOnly
{
    class VideoEncoder
    {
        public void Encode(Video video, Action<Message> notificationHandler)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            notificationHandler(new Message());
        }

    }
}
