using System;

namespace HomeWork_06._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse reverse = new Reverse();
            reverse.Word = "Hello World";

            Console.WriteLine(reverse.Cevir());

            Console.ReadLine();

        }
    }
}
