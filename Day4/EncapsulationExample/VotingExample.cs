using System;

namespace EncapsulationDemo
{
    public class Person
    {
        
        private int age;

        
        public int GetAge()
        {
            return age;
        }

       
        public void SetAge(int ageInput)
        {
            if (ageInput >= 0) 
            {
                this.age = ageInput;
            }
            else
            {
                Console.WriteLine("Age can't be negative.");
            }
        }

       
        public void CheckIfCanVote()
        {
            if (age >= 18)
            {
                Console.WriteLine("You can vote.");
            }
            else
            {
                Console.WriteLine("You can't vote yet. Please wait.");
            }
        }
    }

    class Program1
    {
        public static void Run()
        {
           
            Console.WriteLine("Enter your age:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            
            Person user = new Person();

            user.SetAge(userAge);

            Console.WriteLine("Your age is: " + user.GetAge());

            user.CheckIfCanVote();
        }
    }
}
