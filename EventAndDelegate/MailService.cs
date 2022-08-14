using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) => Console.WriteLine("Mail Service: Sending an mail... " + e.Video.Title);

    }
}
