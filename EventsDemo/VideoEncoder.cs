using System;
using System.Threading;

namespace EventsDemo
{
    public class VideoEncoder 
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
        }
    }
}
