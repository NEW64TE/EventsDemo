using System;
using System.Threading;

namespace EventsDemo
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Thread.Sleep(3000);
            Console.WriteLine("MailService: sending an email...");
        }
    }
}