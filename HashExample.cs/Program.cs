//using System.Collections;


//public class Class2
//{
//    public Class2()
//    {


//        Hashtable hashtable = new Hashtable(); //  initial capacity ,  load factor  , hashcode provider and comparer
//        hashtable.Add("RollNo", "101");

//        hashtable.Add("Name", "Rohan");

//        //or 

//        Console.WriteLine(hashtable["Name"]);

//        foreach (object key in hashtable.Keys)
//        {
//            Console.WriteLine(hashtable[key]);

//        }

//        foreach (DictionaryEntry items in hashtable)
//        {

//            Console.WriteLine($"{items.Key} , {items.Value}");
//        }

//        var cities = new Hashtable()
//        {
//            { "UK" , "London , Manchester"},
//            { "USA" , "Chicago, New Yord"},
//            { "India" , "Mumbai , Delhi"}

//        };



//    }


//}


using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Designation { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static List<Employee> employes = new List<Employee>
    {
        new Employee{ Id = 1,Designation ="developer",Salary =75000},
        new Employee{ Id = 2,Designation = "Analyst",Salary =25000},
        new Employee{ Id = 3,Designation = "Animator",Salary =35000},

    };
}

