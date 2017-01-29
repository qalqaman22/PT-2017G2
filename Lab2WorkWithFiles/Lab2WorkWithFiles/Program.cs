using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader elements = new StreamReader(@"C:\Users\qalqa\Desktop\Numbers\Readme.txt");
            string str = elements.ReadLine();
            string[] arr = str.Split();

            List<int> a = new List<int>();
            foreach(string s in arr)
            {
                a.Add(int.Parse(s));
            }

            
            
          

            

            Console.ReadKey();
         

        }
    }
}
