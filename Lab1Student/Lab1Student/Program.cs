using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //To create a student characteristics
            Student s = new Student("Kalkaman", "Alisher", 18, 3);



            Console.Write(s);

            Console.ReadKey();
        }
    }
}

