using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Task2
{
    class Student:Person
    {
        public static void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public  void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old");
        }
    }
}
