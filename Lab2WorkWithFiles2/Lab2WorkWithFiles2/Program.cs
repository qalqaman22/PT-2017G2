using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //To work with directories/files

namespace Lab2WorkWithFiles2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // "StreamReader" used to take elements from file
            StreamReader st = new StreamReader(@"C:\Users\qalqa\Desktop\Numbers\Readme.txt");
            string s = st.ReadLine();
            string[] arr = s.Split();

            //By this way I convert "string massive" to "int massive"
            int[] c = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                c[i] = int.Parse(arr[i]) + 0;
            }

            //h is a big number, i include it to find minimum number
            int h = 1000;
            
            //for => here are characteristics of prime minimum number
            //We know that prime numbers have 2 divisible(z=2)
            for (int i = 0; i < arr.Length; i++)
            {
                int z = 0;

                for (int j = 1; j <= c[i]; j++)
                {
                    if (c[i] % j == 0)
                        z=z+1;   
                }

                if (z == 2 && c[i] < h && c[i]!=1 && c[i]!=2)
                    h = c[i];

            }

            //Here we creating file by path
            StreamWriter ts = new StreamWriter(@"C:\Users\qalqa\Desktop\Numbers\v.txt");
            //Here we write smth in file
            ts.WriteLine(h);
            //necessery to close file
            ts.Close();

            Console.ReadKey();
        }
    }
}
