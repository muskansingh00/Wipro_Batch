using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling.cs
{
    internal class FilehandlingExample
    {
        string filename = @"C:\Users\ASUS\Documents\VSPurple\ConsoleApp1\Filehandling.cs\bin\Logs.txt";
        FileStream fs = new FileStream(filename, FileMode.Create);
        Console.WriteLine("File created");
    }
}
