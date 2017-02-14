using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SumOfComplex
{
    class Program
    {
        
        
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

                if (sum.x == 0 && sum.y == 0)
                    sum = p;
                else
                sum = sum + p;
            }

            Complex sub = new Complex(0, 0);
            foreach (string s in arr)
            {
                // s = "11/22"
                string[] t = s.Split('/'); // t[0] = 11 t[1] = 22 
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (sub.x == 0 && sub.y == 0)
                    sub = p;
                else
                    sub = sub - p;
            }

            Complex div = new Complex(0, 0);
            
            foreach (string s in arr)
            {
                // s = "11/22"
                string[] t = s.Split('/'); // t[0] = 11 t[1] = 22 
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (div.x == 0 && div.y == 0)
                    div = p;
                else
                    div = div / p;
            }

            Complex mul = new Complex(0, 0);
            foreach (string s in arr)
            {
                // s = "11/22"
                string[] t = s.Split('/'); // t[0] = 11 t[1] = 22 
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (mul.x == 0 && mul.y == 0)
                    mul = p;
                else
                    mul = mul * p;
            }



            //Answer is x and y component of sum divided by greates common factor REDUCTION
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.ReadKey();
        }
    }
}
