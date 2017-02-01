using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2SumOfComplex
{
   
    class Complex
    {
        public int x, y; // variables

        //Structure, because we insert different amount of comlex numbers
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Necessary, we work with structures(without this -> recieve wrong answer)
        public override string ToString()
        {
            
                return x + "/" + y ;
        }

        // create '+ operator' sum of complexes
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.x + c2.x, c1.y + c2.y);
            return c;
        }
    }
}
