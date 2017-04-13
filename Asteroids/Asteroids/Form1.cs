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

namespace Asteroids
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g,gPic,gSic,gMic;
        SolidBrush brushwhite, brushred, brushgreen, brushyellow,brushblue;
        MyAsters myaster1,myaster2,myaster3,myaster4;
        SpaceShip ship;
        MyBullet bullet;
        public int op = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //bmp = new Bitmap(@"C:\Users\qalqa\Desktop\Proga\wallblue.jpg");
            
            gSic = Graphics.FromImage(bmp);
            gSic.FillRectangle(brushblue, 0, 0, pictureBox1.Width, pictureBox1.Height);
           
            pictureBox1.Image = bmp;
            x1++;
            y1++;
            if (x1 == 984)
                x1 = 0;
            if (y1 == 650)
                y1 = 0;
            x2++;
            y2--;
            if (x2 == 984)
                x2 = 0;
            if (y2 == 0)
                y2 = 650;
            x3--;
            y3++;
            if (x3 == 0)
                x3 = 984;
            if (y3 == 650)
                y3 = 0;
            x4--;
            y4--;
            if (x4 == 0)
                x4 = 984;
            if (y4 == 0)
                y4 = 650;
            
            myaster1 = new MyAsters(x1, y1);
            myaster2 = new MyAsters(x2, y2);
            myaster3 = new MyAsters(x3, y3);
            myaster4 = new MyAsters(x4, y4);
            
            a1++;
            b1++;
            if (a1 == 984)
                a1 = 0;
            if (b1 == 650)
                b1 = 0;
            a2--;
            b2++;
            if (a2 == 0)
                a2 = 984;
            if (b2 == 650)
                b2 = 0;
            a3++;
            b3++;
            if (a3 == 984)
                a3 = 0;
            if (b3 == 650)
                b3 = 0;
            a4--;
            b4--;
            if (a4 == 0)
                a4 = 984;
            if (b4 == 0)
                b4 = 650;
            a5--;
            b5++;
            if (a5 == 0)
                a5 = 984;
            if (b5 == 650)
                b5 = 0;
            a6--;
            b6--;
            if (a6 == 0)
                a6 = 984;
            if (b6 == 0)
                b6 = 650;
            a7++;
            b7--;
            if (a7 == 984)
                a7 = 0;
            if (b7 == 0)
                b7 = 650;
            a8++;
            b8--;
            if (a8 == 984)
                a8 = 0;
            if (b8 == 0)
                b8 = 650;

            star1 = new MyStars(a1, b1);
            star2 = new MyStars(a2, b2);
            star3 = new MyStars(a3, b3);
            star4 = new MyStars(a4, b4);
            star5 = new MyStars(a5, b5);
            star6 = new MyStars(a6, b6);
            star7 = new MyStars(a7, b7);
            star8 = new MyStars(a8, b8);
            //ship = new SpaceShip(s1, s2);
          
            //pictureBox1.Refresh();
           
            Paint1();
         
            pictureBox1.Image = bmp;
            //Refresh();
        }

        MyStars star1, star2, star3, star4, star5, star6, star7, star8;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                if (op == 1)
                {
                    s2 = s2 - 7;
                    if (s2 <= 0)
                        s2 = 650;
                }
                else if (op == 2)
                {
                    s1 = s1 + 5;
                    s2 = s2 - 5;
                    if (s1 >= 984)
                        s1 = 0;
                    if (s2 <= 0)
                        s2 = 650;
                }
                else if (op == 3)
                {
                    s1 = s1 + 7;
                    if (s1 >= 984)
                        s1 = 0;
                }
                else if (op == 4)
                {
                    s1 = s1 + 5;
                    s2 = s2 + 5;
                    if (s1 >= 984)
                        s1 = 0;
                    if (s2 >= 650)
                        s2 = 0;
                }
                else if (op == 5)
                {
                    s2 = s2 + 7;
                    if (s2 >= 650)
                        s2 = 0;
                }
                else if(op==6)
                {
                    s1 = s1 - 5;
                    s2 = s2 + 5;
                    if (s1 <= 0)
                        s1 = 984;
                    if (s2 >= 650)
                        s2 = 0;
                }
                else if(op==7)
                {
                    s1 = s1 - 7;
                    if (s1 <= 0)
                        s1 = 984;
                }
                else if(op==8)
                {
                    s1 = s1 - 5;
                    s2 = s2 - 5;
                    if (s1 <= 0)
                        s1 = 984;
                    if (s2 <= 0)
                        s2 = 650;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                op++;
                if (op == 9)
                    op = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                op--;
                if (op == 0)
                    op = 8;
            }


        }
        static int x1 = 180, x2 = 220, x3 = 800, x4 = 610,s1=492;
        static int y1 = 200, y2 = 450, y3 = 170, y4 = 510,s2=325;
        static int a1 = 50, a2 = 400, a3 = 650, a4 = 880, a5 = 770, a6 = 865, a7 = 380, a8 = 70;
        static int b1 = 110, b2 = 60, b3 = 100, b4 = 275, b5 = 400, b6 = 570, b7 = 500, b8 = 510;
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = new Bitmap(@"C:\Users\qalqa\Desktop\Proga\wallblue.jpg");
            gSic = Graphics.FromImage(bmp);
            //gPic = pictureBox1.CreateGraphics();
            //gSic = pictureBox1.CreateGraphics();
            //gMic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;
            

            brushwhite = new SolidBrush(Color.White);
            brushred = new SolidBrush(Color.Red);
            brushgreen = new SolidBrush(Color.Green);
            brushyellow = new SolidBrush(Color.Yellow);
            brushblue = new SolidBrush(Color.Blue);
            
            myaster1 = new MyAsters(180,200);
            myaster2 = new MyAsters(220, 450);
            myaster3 = new MyAsters(800, 170);
            myaster4 = new MyAsters(610, 510);
            
            
            ship = new SpaceShip(492, 325);
            bullet = new MyBullet(492, 240);
            //gun = new MyGun(492, 325);
            star1 = new MyStars(50, 110);
            star2 = new MyStars(400, 60);
            star3 = new MyStars(650, 100);
            star4 = new MyStars(880, 275);
            star5 = new MyStars(770, 400);
            star6 = new MyStars(865, 570);
            star7 = new MyStars(380, 500);
            star8 = new MyStars(70, 510);
           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            //g.FillPath(brushgreen, bullet.path5);
            //g.FillPath(brushgreen, bullet.path6);
            
        }

        public void Paint1() {
            ship = new SpaceShip(s1, s2);
            //g.FillRectangle(brushblue, 0, 0, 984, 650);
            gSic.FillPath(brushwhite, star1.path7);
            gSic.FillPath(brushwhite, star2.path7);
            gSic.FillPath(brushwhite, star3.path7);
            gSic.FillPath(brushwhite, star4.path7);
            gSic.FillPath(brushwhite, star5.path7);
            gSic.FillPath(brushwhite, star6.path7);
            gSic.FillPath(brushwhite, star7.path7);
            gSic.FillPath(brushwhite, star8.path7);

            gSic.FillPath(brushred, myaster1.path1);
            gSic.FillPath(brushred, myaster1.path2);
            gSic.FillPath(brushred, myaster2.path1);
            gSic.FillPath(brushred, myaster2.path2);
            gSic.FillPath(brushred, myaster3.path1);
            gSic.FillPath(brushred, myaster3.path2);
            gSic.FillPath(brushred, myaster4.path1);
            gSic.FillPath(brushred, myaster4.path2);

            gSic.FillPath(brushyellow, ship.path3);
            if (op == 1)
                gSic.FillPath(brushgreen, ship.path11);
            else if (op == 2)
                gSic.FillPath(brushgreen, ship.path12);
            else if (op == 3)
                gSic.FillPath(brushgreen, ship.path13);
            else if (op == 4)
                gSic.FillPath(brushgreen, ship.path14);
            else if (op == 5)
                gSic.FillPath(brushgreen, ship.path15);
            else if (op == 6)
                gSic.FillPath(brushgreen, ship.path16);
            else if (op == 7)
                gSic.FillPath(brushgreen, ship.path17);
            else if (op == 8)
                gSic.FillPath(brushgreen, ship.path18);


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
