using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SumOfComplex
{
    class Program
    {
        //To find maximum division
        public static int maxdiv(int a, int b)
        {
            if (a == 0)
                return b;
            return maxdiv (b % a, a);
        }

        
        static void Main(string[] args)
        {
            // 1/2 3/4 2/5
            string inp = Console.ReadLine(); // s = "1/2 3/4"
            string[] arr = inp.Split(); // arr[0] = "11/22", arr[1] = "3/4"

            // "Counter" sum
            Complex sum = new Complex(0, 0);

            //To get 11 and 22 by division by '/'
            foreach (string s in arr)
            {
                // s = "11/22"
                string[] t = s.Split('/'); // t[0] = 11 t[1] = 22 
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                sum = sum + p;
            }
            //Answer is x and y component of sum divided by greates common factor REDUCTION
            Console.WriteLine(sum.x/(maxdiv(sum.x,sum.y)) + "/" + sum.y / (maxdiv(sum.x, sum.y)) );
            Console.ReadKey();
        }
    }
}
