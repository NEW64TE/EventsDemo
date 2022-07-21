using System;
using System.Threading;

namespace EventsDemo
{
    partial class Program
    {
        public class MessageService
        {
            public void OnVideoEncoded(object source, VideoEventArgs e)
            {
                Thread.Sleep(3000);
                Console.WriteLine("MailService: sending a text message for {0}...", e.Video.Title);
            }
        }
    }
}