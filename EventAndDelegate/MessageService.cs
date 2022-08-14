using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) => Console.WriteLine("Message Service: Sending a text message... " + e.Video.Title);

    }
}
