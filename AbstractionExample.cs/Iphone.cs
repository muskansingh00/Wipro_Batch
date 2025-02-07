using System;

namespace Mobile
{
    public class IPHONE : AbstractMobile
    {
        public override void Messages()
        {
            Console.WriteLine("Sending message from IPHONE.");
        }
    }
}
