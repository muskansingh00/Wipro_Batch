using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mobile Brand (REDMI or IPHONE): ");
            string mobileBrand = Console.ReadLine();

            AbstractMobile mobile = MobileNames.GetMobileName(mobileBrand);

            if (mobile != null)
            {
                mobile.Messages();
            }
            else
            {
                Console.WriteLine("Invalid Mobile Brand!");
            }
        }
    }
}
