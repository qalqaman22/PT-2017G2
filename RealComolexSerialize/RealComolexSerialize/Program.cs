using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Lab2SumOfComplex
{
    [Serializable]
    class Program
    {
        public static void save(Complex a,Complex b,Complex c,Complex d)
        {
            FileStream fa = new FileStream("a.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fb = new FileStream("b.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fc = new FileStream("c.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fd = new FileStream("d.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fa, a);
                bf.Serialize(fb, b);
                bf.Serialize(fc, c);
                bf.Serialize(fd, d);
            }
            catch
            {
                Console.Write("serialize error");
            }
            finally
            {
                fa.Close();
                fb.Close();
                fc.Close();
                fd.Close();
            }
        }

        public static void deser(Complex a,Complex b,Complex c,Complex d)
        {
            Console.Clear();
            FileStream fa = new FileStream("a.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fb = new FileStream("b.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fc = new FileStream("c.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fd = new FileStream("d.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                a = bf.Deserialize(fa) as Complex;
                Console.WriteLine(a);
                b = bf.Deserialize(fb) as Complex;
                Console.WriteLine(b);
                c = bf.Deserialize(fc) as Complex;
                Console.WriteLine(c);
                d = bf.Deserialize(fd) as Complex;
                Console.WriteLine(d);

                Console.ReadKey();
            }
            catch
            {
                Console.Write("deserialize error");
            }
            finally
            {
                fa.Close();
                fb.Close();
                fc.Close();
                fd.Close();
            }


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

            ConsoleKeyInfo btn = Console.ReadKey();
            switch (btn.Key)
            {
                case ConsoleKey.F2:
                    save(sum, sub, div,mul);
                    //XmlSave(c);
                    break;
                case ConsoleKey.F3:
                    deser(sum,sub, div,mul);
                    break;
            }
            Console.ReadKey();

        }
    }
}
