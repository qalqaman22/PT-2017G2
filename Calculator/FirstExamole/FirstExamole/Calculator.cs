using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExamole
{
    class Calculator
    {
        public enum Operation
        {
            NONE,//пока ничего у нас нет
            NUMBER, PLUS, MINUS, MUL, DIV
        };
        public Operation operation;
        public double firstNumber, secondNumber;


        public Calculator()
        {
            operation = Operation.NONE;
            firstNumber = 0;
            secondNumber = 0;
        }

        public void saveFirstNumber(string s)
        {
            firstNumber = double.Parse(s);
        }
        public void saveSecondNumber(string s)
        {
            secondNumber = double.Parse(s);
        }
        public string getResultPlus()
        {
            //if((firstNumber + secondNumber) % 1 == 0)
                return (firstNumber + secondNumber).ToString();
            //else
                //return deleteZeros(String.Format("{0:0.0000}", firstNumber + secondNumber));
        }
        public string getResultMinus()
        {
            //if ((firstNumber - secondNumber) % 1 == 0)
                return (firstNumber - secondNumber).ToString();
            //else
              //  return deleteZeros(String.Format("{0:0.0000}", firstNumber - secondNumber));
        }
        public string getResultMul()
        {
            //if ((firstNumber * secondNumber) % 1 == 0)
                return (firstNumber * secondNumber).ToString();
            //else
         //       return deleteZeros(String.Format("{0:0.0000}", firstNumber * secondNumber));
        }
        public string getResultDiv()
        {
            //if ((firstNumber / secondNumber) % 1 == 0)
                return (firstNumber / secondNumber).ToString();
            //else
              //  return deleteZeros(String.Format("{0:0.0000}", firstNumber / secondNumber));
        }
        public double changeSign(string s)
        {
            int x = int.Parse(s);
            return x * (-1);
        }
        public string deleteLast(string s)
        {
            string x = "";
            char[] arr = s.ToCharArray();
            for (int i = 0; i < s.Length - 1; i++)
                x = x + s[i];
            return x;
        }
        
        
        public string quadratOp(string s)
        {
            double x = double.Parse(s);
            return (x * x).ToString();
        }
        public string onedivX(string s)
        {
            double x = double.Parse(s);
            return (1 / x).ToString();
        }
        public string sqrootOp(string s)
        {
            double x = double.Parse(s);
            return (Math.Sqrt(x)).ToString();
        }
        public bool dotTF(string s)
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == ',')
                    counter++;
            if (counter == 0)
                return false;
            else
                return true;
        }
        public string procentOp(string s)
        {
            return (double.Parse(s) / 100 * firstNumber).ToString();
        }
    }
}
