using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   //To work with directories

namespace Lab2WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {   
            //numbers in file become => elements by "StreamReader" 
            StreamReader elements = new StreamReader(@"C:\Users\qalqa\Desktop\Numbers\Readme.txt");
            string str = elements.ReadLine();
            string[] arr = str.Split();
            
            // Way to convert "string massive" to "int massive"
            int[] c = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                c[i] = int.Parse(arr[i]) - 0;
            }

            //Last action is to find max and min of elements
                int x = (-1000);
                int y = 1000;

                for (int i=0; i<arr.Length; i++)
            {
                if (c[i] > x)
                    x = c[i];
                if (c[i] < y)
                    y = c[i];
            }



            Console.WriteLine("Maximum is " + x);
            Console.WriteLine("Minimum is " + y);


            Console.ReadKey();
         

        }
    }
}
