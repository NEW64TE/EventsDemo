using System;
using System.Threading;

namespace EventsDemo
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Thread.Sleep(3000);
            Console.WriteLine("MailService: sending an email for {0}...", e.Video.Title);
        }
    }
}