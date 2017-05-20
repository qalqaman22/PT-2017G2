using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = (int.Parse(button1.Text) + 1).ToString();
            if (int.Parse(button1.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = (int.Parse(button2.Text) + 1).ToString();
            if (int.Parse(button2.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = (int.Parse(button3.Text) + 1).ToString();
            if (int.Parse(button3.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = (int.Parse(button4.Text) + 1).ToString();
            if (int.Parse(button4.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = (int.Parse(button5.Text) + 1).ToString();
            if (int.Parse(button5.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = (int.Parse(button6.Text) + 1).ToString();
            if (int.Parse(button6.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = (int.Parse(button7.Text) + 1).ToString();
            if (int.Parse(button7.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = (int.Parse(button8.Text) + 1).ToString();
            if (int.Parse(button8.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = (int.Parse(button9.Text) + 1).ToString();
            if (int.Parse(button9.Text) % 2 == 0)
                textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }
    }
}
