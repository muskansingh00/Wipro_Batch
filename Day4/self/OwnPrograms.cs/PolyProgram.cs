using System;
using System.Threading.Channels;

namespace OwnPrograms.cs
{
    internal class PolyProgram
    {
        //Method overloading
       /* public void Add(int a , int b)
        {
            Console.WriteLine("The sum is :" +(a+b));
        }

        public void Add(float a , float b) 
        { 
            Console.WriteLine("The sum is :" +(a+b)); 
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("The sum is :" + (a + b));
        }
        public void Add(int a, int b,int c)
        {
            Console.WriteLine("The sum is :" + (a + b +c));
        }
        public void Add(int a, float b)
        {
            Console.WriteLine("The sum is :" + (a + b));
        }
        public void Add(float a, string b)
        {
            Console.WriteLine("The sum is :" + (a +" "+ b));
        }*/

       

        //Method Overriding
        class Class1 {
            public virtual void Show()
            {
                Console.WriteLine("This is Parent class ");
            }
        }

        class Class2 : Class1
        {
            public override void Show()
            {
                Console.WriteLine("This is child class");
            }
        }



        public static void Main1(string[] args)
        {
            //PolyProgram p = new PolyProgram();

            //overloading
            //p.Add(2, 3);
            //p.Add(4, 5.0f);
            //p.Add("Muskan", "Dhama")

            //Class2 obj = new Class2();
            //obj.Show(); //Runtime Polymorphism

            //Class1 ob = new Class2();
            //ob.Show();

            //Class2 class2 = new Class2();
            //class2.Show();
           


        }
    }
}
