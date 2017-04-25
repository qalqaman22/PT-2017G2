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
        Graphics gSic;
        SolidBrush brushwhite, brushred, brushgreen, brushyellow,brushblue;
        MyAsters myaster1,myaster2,myaster3,myaster4;
        SpaceShip ship;
        List<MyBullet> buls;
        public int op = 1, r1=13, r2=17,r3=8, Rs=20;
        public string gm = "GameOver";
        static int cntrecharge=0;
        static int score = 0;
        static bool aster1exist = true;
        static bool aster2exist = true;
        static bool aster3exist = true;
        static bool aster4exist = true;
        static bool star1exist = true;
        static bool star2exist = true;
        static bool star3exist = true;
        static bool star4exist = true;
        static bool star5exist = true;
        static bool star6exist = true;
        static bool star7exist = true;
        static bool star8exist = true;
        static bool shipexist = true;

        static int jaiaster1 = 0, jaiaster2 = 0, jaiaster3 = 0, jaiaster4 = 0;
        static int jaistar1 = 0, jaistar2 = 0, jaistar3 = 0, jaistar4 = 0, jaistar5 = 0, jaistar6 = 0, jaistar7 = 0, jaistar8 = 0;

        static int x1 = 180, x2 = 220, x3 = 800, x4 = 610, s1 = 492;
        static int y1 = 200, y2 = 450, y3 = 170, y4 = 510, s2 = 325;
        static int a1 = 50, a2 = 400, a3 = 650, a4 = 880, a5 = 770, a6 = 865, a7 = 380, a8 = 70;
        static int b1 = 110, b2 = 60, b3 = 100, b4 = 275, b5 = 400, b6 = 570, b7 = 500, b8 = 510;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gSic = Graphics.FromImage(bmp);
            gSic.FillRectangle(brushblue, 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;

            if(buls.Count()==10)
            cntrecharge++;
            //5 sec recharge
            if (cntrecharge == 200)
            {
                cntrecharge = 0;
                buls.Clear();
            }
                if (buls != null)
                {
                    foreach (MyBullet b in buls)
                    {
                    if (Math.Abs(b.getX() - x1) <= r2 + r3 && Math.Abs(b.getY() - y1) <= r2 + r3 && jaiaster1==0)
                    {
                        aster1exist = false;
                        jaiaster1 = 1;
                        score = score + 100;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - x2) <= r2 + r3 && Math.Abs(b.getY() - y2) <= r2 + r3 && jaiaster2 == 0)
                    {
                        aster2exist = false;
                        jaiaster2 = 1;
                        score = score + 100;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - x3) <= r2 + r3 && Math.Abs(b.getY() - y3) <= r2 + r3 && jaiaster3 == 0)
                    {
                        aster3exist = false;
                        jaiaster3 = 1;
                        score = score + 100;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - x4) <= r2 + r3 && Math.Abs(b.getY() - y4) <= r2 + r3 && jaiaster4 == 0)
                    {
                        aster4exist = false;
                        jaiaster4 = 1;
                        score = score + 100;
                        label1.Text = "Score : " + score.ToString();
                    }

                    if (Math.Abs(b.getX() - a1) <= r1 + r3 && Math.Abs(b.getY() - b1) <= r1 + r3 && jaistar1 == 0)
                    {
                        star1exist = false;
                        jaistar1 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a2) <= r1 + r3 && Math.Abs(b.getY() - b2) <= r1 + r3 && jaistar2 == 0)
                    {
                        star2exist = false;
                        jaistar2 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a3) <= r1 + r3 && Math.Abs(b.getY() - b3) <= r1 + r3 && jaistar3 == 0)
                    {
                        star3exist = false;
                        jaistar3 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a4) <= r1 + r3 && Math.Abs(b.getY() - b4) <= r1 + r3 && jaistar4 == 0)
                    {
                        star4exist = false;
                        jaistar4 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a5) <= r1 + r3 && Math.Abs(b.getY() - b5) <= r1 + r3 && jaistar5 == 0)
                    {
                        star5exist = false;
                        jaistar5 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a6) <= r1 + r3 && Math.Abs(b.getY() - b6) <= r1 + r3 && jaistar6 == 0)
                    {
                        star6exist = false;
                        jaistar6 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a7) <= r1 + r3 && Math.Abs(b.getY() - b7) <= r1 + r3 && jaistar7 == 0)
                    {
                        star7exist = false;
                        jaistar7 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }
                    if (Math.Abs(b.getX() - a8) <= r1 + r3 && Math.Abs(b.getY() - b8) <= r1 + r3 && jaistar8 == 0)
                    {
                        star8exist = false;
                        jaistar8 = 1;
                        score = score + 200;
                        label1.Text = "Score : " + score.ToString();
                    }

                    b.BulMove(buls);
                    
                    }
                }

            if (aster1exist)
            {
                x1++;
                y1++;
            }
            else if(!aster1exist)
            {
                x1 = -2000;
                y1 = -2000;
            }
                if (x1 == 984)
                    x1 = 0;
                if (y1 == 650)
                    y1 = 0;
            if (aster2exist)
            {
                x2++;
                y2--;
            }
            else if (!aster1exist)
            {
                x2 = -2000;
                y2 = -2000;
            }
            if (x2 == 984)
                    x2 = 0;
                if (y2 == 0)
                    y2 = 650;
            if (aster3exist)
            {
                x3--;
                y3++;
            }
            else if (!aster1exist)
            {
                x3 = -2000;
                y3 = -2000;
            }
            if (x3 == 0)
                    x3 = 984;
                if (y3 == 650)
                    y3 = 0;
            if (aster4exist)
            {
                x4--;
                y4--;
            }
            else if (!aster1exist)
            {
                x4 = -2000;
                y4 = -2000;
            }
            if (x4 == 0)
                    x4 = 984;
                if (y4 == 0)
                    y4 = 650;

                myaster1 = new MyAsters(x1, y1);
                myaster2 = new MyAsters(x2, y2);
                myaster3 = new MyAsters(x3, y3);
                myaster4 = new MyAsters(x4, y4);

            if (star1exist)
            {
                a1++;
                b1++;
            }
            else if (!star1exist)
            {
                a1 = -2000;
                b1 = -2000;
            }
            if (a1 == 984)
                    a1 = 0;
                if (b1 == 650)
                    b1 = 0;
            if (star2exist)
            {
                a2--;
                b2++;
            }
            else if (!star2exist)
            {
                a2 = -2000;
                b2 = -2000;
            }
            if (a2 == 0)
                    a2 = 984;
                if (b2 == 650)
                    b2 = 0;
            if (star3exist)
            {
                a3++;
                b3++;
            }
            else if (!star3exist)
            {
                a3 = -2000;
                b3 = -2000;
            }
            if (a3 == 984)
                    a3 = 0;
                if (b3 == 650)
                    b3 = 0;
            if (star4exist)
            {
                a4--;
                b4--;
            }
            else if (!star4exist)
            {
                a4 = -2000;
                b4 = -2000;
            }
            if (a4 == 0)
                    a4 = 984;
                if (b4 == 0)
                    b4 = 650;
            if (star5exist)
            {
                a5--;
                b5++;
            }
            else if (!star5exist)
            {
                a5 = -2000;
                b5 = -2000;
            }
            if (a5 == 0)
                    a5 = 984;
                if (b5 == 650)
                    b5 = 0;
            if (star6exist)
            {
                a6--;
                b6--;
            }
            else if (!star6exist)
            {
                a6 = -2000;
                b6 = -2000;
            }
            if (a6 == 0)
                    a6 = 984;
                if (b6 == 0)
                    b6 = 650;
            if (star7exist)
            {
                a7++;
                b7--;
            }
            else if (!star7exist)
            {
                a7 = -2000;
                b7 = -2000;
            }
            if (a7 == 984)
                    a7 = 0;
                if (b7 == 0)
                    b7 = 650;
            if (star8exist)
            {
                a8++;
                b8--;
            }
            else if (!star8exist)
            {
                a8 = -2000;
                b8 = -2000;
            }
            if (a8 == 984)
                    a8 = 0;
                if (b8 == 0)
                    b8 = 650;
            
        if (Math.Abs(s1 - a1) <= r1 + Rs && Math.Abs(s2 - b1) <= r1 + Rs ||
            Math.Abs(s1 - a2) <= r1 + Rs && Math.Abs(s2 - b2) <= r1 + Rs ||
            Math.Abs(s1 - a3) <= r1 + Rs && Math.Abs(s2 - b3) <= r1 + Rs ||
            Math.Abs(s1 - a4) <= r1 + Rs && Math.Abs(s2 - b4) <= r1 + Rs ||
            Math.Abs(s1 - a5) <= r1 + Rs && Math.Abs(s2 - b5) <= r1 + Rs ||
            Math.Abs(s1 - a6) <= r1 + Rs && Math.Abs(s2 - b6) <= r1 + Rs ||
            Math.Abs(s1 - a7) <= r1 + Rs && Math.Abs(s2 - b7) <= r1 + Rs ||
            Math.Abs(s1 - a8) <= r1 + Rs && Math.Abs(s2 - b8) <= r1 + Rs ||
            Math.Abs(s1 - x1) <= r2 + Rs && Math.Abs(s2 - y1) <= r2 + Rs ||
            Math.Abs(s1 - x2) <= r2 + Rs && Math.Abs(s2 - y2) <= r2 + Rs ||
            Math.Abs(s1 - x3) <= r2 + Rs && Math.Abs(s2 - y3) <= r2 + Rs ||
            Math.Abs(s1 - x4) <= r2 + Rs && Math.Abs(s2 - y4) <= r2 + Rs)
            {
                aster1exist = false;
                aster2exist = false;
                aster3exist = false;
                aster4exist = false;
                star1exist = false;
                star2exist = false;
                star3exist = false;
                star4exist = false;
                star5exist = false;
                star6exist = false;
                star7exist = false;
                star8exist = false;
                shipexist = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Text = "Your score : " + score.ToString();
                label6.Visible = true;
            }

            label2.Text = "Bullets left : " + (10 - buls.Count()).ToString();
            if (cntrecharge>0 && cntrecharge<100)
                label2.Text = "Bullets are recharging..";
            if (cntrecharge >= 100 && cntrecharge < 200)
                label2.Text = "Wait 5 seconds";
            
                star1 = new MyStars(a1, b1);
                star2 = new MyStars(a2, b2);
                star3 = new MyStars(a3, b3);
                star4 = new MyStars(a4, b4);
                star5 = new MyStars(a5, b5);
                star6 = new MyStars(a6, b6);
                star7 = new MyStars(a7, b7);
                star8 = new MyStars(a8, b8);
            //ship = new SpaceShip(s1, s2);

            //bullet = new MyBullet(gSic, new Point(492, 325), op);
            
            
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
            if(e.KeyCode==Keys.Space)
            {
                if (buls.Count() < 10)
                {
                    buls.Add(new MyBullet(gSic, new Point(s1, s2), op));
                }
            }
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //bmp = new Bitmap(@"C:\Users\qalqa\Desktop\Proga\wallblue.jpg");
            gSic = Graphics.FromImage(bmp);
            //gPic = pictureBox1.CreateGraphics();
            //gSic = pictureBox1.CreateGraphics();
            //gMic = pictureBox1.CreateGraphics();
            pictureBox1.Image = bmp;

            buls = new List<MyBullet>();

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
            //bullet = new MyBullet(492, 325);
            //bullet = new MyBullet(gSic, new Point(492, 240), op);
            
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
            
        }

        public void Paint1() {
            ship = new SpaceShip(s1, s2);
            //g.FillRectangl(brushblue, 0, 0, 984, 650);
            if (score == 2000)
                label3.Visible = true;
            if(star1exist)
            gSic.FillPath(brushwhite, star1.path7);
            if(star2exist)
            gSic.FillPath(brushwhite, star2.path7);
            if(star3exist)
            gSic.FillPath(brushwhite, star3.path7);
            if(star4exist)
            gSic.FillPath(brushwhite, star4.path7);
            if(star5exist)
            gSic.FillPath(brushwhite, star5.path7);
            if(star6exist)
            gSic.FillPath(brushwhite, star6.path7);
            if(star7exist)
            gSic.FillPath(brushwhite, star7.path7);
            if(star8exist)
            gSic.FillPath(brushwhite, star8.path7);

            if (aster1exist)
            {
                gSic.FillPath(brushred, myaster1.path1);
                gSic.FillPath(brushred, myaster1.path2);
            }
            if (aster2exist)
            {
                gSic.FillPath(brushred, myaster2.path1);
                gSic.FillPath(brushred, myaster2.path2);
            }
            if (aster3exist)
            {
                gSic.FillPath(brushred, myaster3.path1);
                gSic.FillPath(brushred, myaster3.path2);
            }
            if (aster4exist)
            {
                gSic.FillPath(brushred, myaster4.path1);
                gSic.FillPath(brushred, myaster4.path2);
            }
            if(shipexist)
            gSic.FillPath(brushyellow, ship.path3);
            if (shipexist)
            {
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

            if (shipexist)
            {
                if (buls != null)
                {
                    foreach (MyBullet b in buls)
                    {
                        b.BulDraw(gSic);
                    }
                }
            }
            //gSic.FillPath(brushgreen, bullet.path5);
            //gSic.FillPath(brushgreen, bullet.path6);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
