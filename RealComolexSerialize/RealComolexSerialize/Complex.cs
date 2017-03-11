using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lab2SumOfComplex
{
    [Serializable]
    class Complex
    {
        public int x, y; // variables

        //To find maximum division
        public static int maxdiv(int a, int b)
        {
            if (a == 0)
                return b;
            return maxdiv(b % a, a);
        }

        //Structure, because we insert different amount of comlex numbers
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Necessary, we work with structures(without this -> recieve wrong answer)
        public override string ToString()
        {

            return x / maxdiv(x, y) + "/" + y / maxdiv(x, y);
        }

        // create '+ operator' sum of complexes
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.x * c2.y + c2.x * c1.y, c1.y * c2.y);
            return c;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.x * c2.y - c2.x * c1.y, c1.y * c2.y);
            return c;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.x * c2.x, c1.y * c2.y);
            return c;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.x * c2.y, c1.y * c2.x);
            return c;
        }

    }
}
