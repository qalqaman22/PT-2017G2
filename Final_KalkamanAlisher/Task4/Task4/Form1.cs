using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Point p;
        List<Point> pts;
        SolidBrush brush;
        Point tr;
        private static int x,y;
        

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            //p = new Point(0, 0);
            tr = new Point(0, 0);
            pts = new List<Point>();
            brush = new SolidBrush(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            for (int i = 0; i < pts.Count; i++)
            {
                if (pts[i].Y >= pictureBox1.Height - 5)
                    //p = new Point(pts[i].X, pts[i].Y);
                    pts[i] = new Point(pts[i].X, pts[i].Y);
                else
                    pts[i] = new Point(pts[i].X, pts[i].Y + 3);
            }
            if(pts.Count>0)
            DrawCircle();

        }

        public void DrawCircle()
        {
            for(int i=0;i<pts.Count;i++)
            {
                g.FillEllipse(brush, pts[i].X - 5, pts[i].Y - 5, 10, 10);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tr = new Point(e.Location.X, e.Location.Y);
            pts.Add(tr);
        }
    }
}
