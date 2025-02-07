using System;
using System.Threading.Tasks;

namespace Mobile
{
    public abstract class AbstractMobile
    {
        public abstract void Messages();
    }
    public class MobileNames
    {
        public static AbstractMobile GetMobileName(string MobileName)
        {
            AbstractMobile mobileobj = null; 

            if (MobileName == "REDMI")
            {
                mobileobj = new REDMI(); 
            }
            else if (MobileName == "IPHONE")
            {
                mobileobj = new IPHONE(); 
            }
            return mobileobj; 
        }
    }

}
