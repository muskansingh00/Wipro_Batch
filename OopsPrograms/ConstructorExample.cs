using System;

using System.Threading.Tasks;

namespace OopsPrograms
{
    internal class Person
    {
        public string Name;
        public int Age;
        //default constructor
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public Person(Person p)
        {
            Name = p.Name;
            Age =p.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name :{Name} ,Age : {Age}");
        }
    }
    class MainProgram
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Muskan", 20);
            person1.Display();

            Person person2 = new Person(person1);
            person2.Display();

            //Non copy value
            person2.Name = "Khusboo";
            person2.Age = 35;
            person2.Display();
        }
    }
}
