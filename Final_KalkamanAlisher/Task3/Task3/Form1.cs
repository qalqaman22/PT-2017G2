using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        private static int cnt = 0;
        private static int x;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt++;
            x = cnt % 3;

            if (x == 0)
                button1.BackColor = Color.Red;
            if(x==1)
                button1.BackColor = Color.Yellow;
            if(x==2)
                button1.BackColor = Color.Blue;
        }
    }
}
