using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        public static bool checkPrime(string name)
        {
            int cnt = 0;
            StreamReader sr = new StreamReader(name);
            string str = sr.ReadLine();
            string[] arr = str.Split(' ');
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);

            for(int i=2;i<=Math.Min(x,y);i++)
            {
                if (x % i == 0 && y % i == 0)
                    cnt++;
            }

            if (cnt == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\qalqa\Documents\Visual Studio 2015\Projects\Final_KalkamanAlisher\Task 1\Task1files");
            FileInfo[] file = dir.GetFiles();

            for (int i = 0; i < file.Length; i++)
            {
                if (checkPrime(file[i].FullName))
                    Console.WriteLine(file[i].Name + ": " + "yes");
                else
                    Console.WriteLine(file[i].Name + ": " + "no");
            }
            Console.ReadKey();
        }
    }
}
