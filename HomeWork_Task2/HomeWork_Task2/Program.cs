using System;

namespace HomeWork_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("\n***********************************************\n");

            Student student = new Student();
            student.SetAge(26);
            Person.Greet();
            Student.Study();
            student.ShowAge();
            

            Console.WriteLine("\n***********************************************\n");

            Teacher teacher = new Teacher();
            teacher.SetAge(45);
            Person.Greet();
            Teacher.Explain();

            Console.WriteLine("\n***********************************************\n");

        }
    }


}
