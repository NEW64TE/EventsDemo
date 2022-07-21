using System;
using System.Threading;

namespace EventsDemo
{
    public class VideoEncoder 
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideEncoded != null)
            {
                VideEncoded(this, EventArgs.Empty);
            }
        }
    }
}
