﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    class Program
    {
        static bool Prime(int x)
        {
            int a = x;
            int b = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    b++;
            }
            //prime numbers are divisible by themselves and 1;
            if (b == 2)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Numbers : ");

            //To enter our numbers and to separate by gapst(arrays)
            string s = Console.ReadLine();
            string[] arr = s.Split();

            //To identidy array's cells
            for (int i = 0; i < arr.Length; i++)
            {
                // int = int, because in function Prime we return arr[i](int);
                if (Prime(int.Parse(arr[i])) == true)
                    Console.WriteLine(int.Parse(arr[i]));

            }

            Console.ReadKey();
        }
    }
}
