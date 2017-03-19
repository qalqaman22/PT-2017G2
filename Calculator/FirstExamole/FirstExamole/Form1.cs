using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExamole
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        private int op = 0;
        private int equalcnt = 0;
        private double manyequals2 = 0;
        private int currentSize = 28;
        private int manyoperator = 0;
        private double mnumber = 0;
        private int mcnt = 0;
        private int savebtns = 0;
        
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void number_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;


            if (calculator.operation == Calculator.Operation.NONE ||
                calculator.operation == Calculator.Operation.NUMBER)
            {
                if (Display.Text == "0" && btn.Text != "," || equalcnt > 0 || savebtns > 0)
                    Display.Text = btn.Text;
                else if (calculator.dotTF(Display.Text) && btn.Text == "," || Display.Text.Length > 13)
                    Display.Text += "";
                else
                    Display.Text += btn.Text;
                equalcnt = 0;
                savebtns = 0;
            }
            else if (calculator.operation == Calculator.Operation.PLUS)
            {
                manyoperator++;
                if (manyoperator > 1)
                {
                    calculator.saveSecondNumber(Display.Text);
                    Display.Text = calculator.getResultPlus();
                }
                equalcnt = 0;
                op = 1;
                calculator.saveFirstNumber(Display.Text);
                if (btn.Text == "MR")
                {
                    savebtns++;
                    Display.Text = mnumber.ToString();
                }
                else
                    Display.Text = btn.Text;
            }
            else  if (calculator.operation == Calculator.Operation.MINUS)
            {
                manyoperator++;
                if (manyoperator>1)
                {
                    calculator.saveSecondNumber(Display.Text);
                    Display.Text = calculator.getResultMinus();
                }
                equalcnt = 0;
                op = 2;
                calculator.saveFirstNumber(Display.Text);
                if (btn.Text == "MR")
                {
                    savebtns++;
                    Display.Text = mnumber.ToString();
                }
                else
                    Display.Text = btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.MUL)
            {
                manyoperator++;
                if(manyoperator>1)
                {
                    calculator.saveSecondNumber(Display.Text);
                    Display.Text = calculator.getResultMul();
                }
                equalcnt = 0;
                op = 3;
                calculator.saveFirstNumber(Display.Text);
                if (btn.Text == "MR")
                {
                    savebtns++;
                    Display.Text = mnumber.ToString();
                }
                else
                    Display.Text = btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.DIV)
            {
                manyoperator++;
                if (manyoperator > 1)
                {
                    calculator.saveSecondNumber(Display.Text);
                    Display.Text = calculator.getResultDiv();
                }
                equalcnt = 0;
                op = 4;
                calculator.saveFirstNumber(Display.Text);
                if (btn.Text == "MR")
                {
                    savebtns++;
                    Display.Text = mnumber.ToString();
                }
                else
                    Display.Text = btn.Text;
            }
            
            calculator.operation = Calculator.Operation.NUMBER;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Display.Text.Length < 12)
                currentSize = 28;

            if (Display.Text.Length > 11 && Display.Text.Length < 15)
                currentSize = 23;
            if (Display.Text.Length > 14 && Display.Text.Length <= 20)
                currentSize = 18;
            Display.Font = new Font(Display.Font.Name, currentSize,
              Display.Font.Style, Display.Font.Unit);            
         }
        
        private void button11_Click(object sender, EventArgs e)
        {
            //+ - * ÷
            Button button = sender as Button;
                if (button.Text=="+")
            calculator.operation = Calculator.Operation.PLUS;
            if (button.Text == "-")
            calculator.operation = Calculator.Operation.MINUS;
                if(button.Text == "*")
            calculator.operation = Calculator.Operation.MUL;
                if(button.Text=="÷")
            calculator.operation = Calculator.Operation.DIV;
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            // = equal
            
            manyoperator = 0;
            equalcnt++;
            calculator.saveSecondNumber(Display.Text);
            if (equalcnt == 1)
                manyequals2 = calculator.secondNumber;
               if (equalcnt > 1)
                {
                    if (op == 1)
                        Display.Text = (calculator.firstNumber+manyequals2).ToString();
                    if (op == 2)
                        Display.Text = (calculator.firstNumber-manyequals2).ToString();
                    if (op == 3)
                        Display.Text = (calculator.firstNumber*manyequals2).ToString();
                    if (op == 4)
                        Display.Text = (calculator.firstNumber/manyequals2).ToString();
                }
                else
                {
                    if (op == 1)
                        Display.Text = calculator.getResultPlus();
                    if (op == 2)
                        Display.Text = calculator.getResultMinus();
                    if (op == 3)
                        Display.Text = calculator.getResultMul();
                    if (op == 4)
                        Display.Text = calculator.getResultDiv();
                }

            calculator.firstNumber = double.Parse(Display.Text);
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
                
            //sign +-
            if(btn.Text== "±")
            Display.Text = calculator.changeSign(Display.Text).ToString();
            //%
            if (btn.Text == "%")
            {
                //if (percentcnt == 1)
                  //  calculator.firstNumber = 0;
                Display.Text = calculator.procentOp(Display.Text);
                //percentcnt = 0;
            }
            //√
            if(btn.Text== "√")
                Display.Text = calculator.sqrootOp(Display.Text);
            //x²
            if(btn.Text== "x²")
                Display.Text = calculator.quadratOp(Display.Text);
            // 1/x
            if(btn.Text=="1/x")
                Display.Text = calculator.onedivX(Display.Text);
            equalcnt = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //clear fully,clear mumber,backspace
            Button btn = sender as Button;
            if (btn.Text == "C")
            {
                calculator.firstNumber = 0;
                clearDisplay();
            }
            if(btn.Text=="CE")
            {
                clearDisplay();
            }
            if(btn.Text== "←")
            {
                Display.Text = calculator.deleteLast(Display.Text);
                if (Display.Text == "")
                    Display.Text = "0";
            }
            equalcnt = 0;
        }
        private void clearDisplay()
        {
            Display.Text = "0";
            equalcnt = 0;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //MC
            if (btn.Text == "MC")
            {
                mnumber = 0;
                mcnt = 0;
                button25.Enabled = false;
                button26.Enabled = false;
            }
            //MS
            if(btn.Text=="MS")
            {
                
                button25.Enabled = true;
                button26.Enabled = true; 
                savebtns++;
                mnumber = double.Parse(Display.Text);
                mcnt = 0;
            }
            //M+
            if(btn.Text=="M+")
            {
                button25.Enabled = true;
                button26.Enabled = true;
                savebtns++;
                mcnt++;
                if (mcnt == 1)
                    mnumber = double.Parse(Display.Text);
                else
                    mnumber = mnumber + double.Parse(Display.Text);
            }
            //M-
            if(btn.Text=="M-")
            {
                button25.Enabled = true;
                button26.Enabled = true;
                savebtns++;
                mcnt++;
                if (mcnt == 1)
                    mnumber = double.Parse(Display.Text) * (-1);
                else
                    mnumber = mnumber - double.Parse(Display.Text);
            }
        }
    }
}
