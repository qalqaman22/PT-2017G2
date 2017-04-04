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
        Graphics g;
        SolidBrush brushwhite;
        SolidBrush brushred;
        SolidBrush brushgreen;
        SolidBrush brushyellow;
        MyAsters myaster1,myaster2,myaster3,myaster4;
        SpaceShip ship;
        MyBullet bullet;
        MyGun gun;
        MyStars star1, star2, star3, star4, star5, star6, star7, star8;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp = new Bitmap(@"C:\Users\qalqa\Desktop\Proga\wallblue.jpg");
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            brushwhite = new SolidBrush(Color.White);
            brushred = new SolidBrush(Color.Red);
            brushgreen = new SolidBrush(Color.Green);
            brushyellow = new SolidBrush(Color.Yellow);
            myaster1 = new MyAsters(180, 200);
            myaster2 = new MyAsters(220, 450);
            myaster3 = new MyAsters(800, 170);
            myaster4 = new MyAsters(610, 510);
            ship = new SpaceShip(492, 325);
            bullet = new MyBullet(487, 240);
            gun = new MyGun(492, 325);
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
            g.FillPath(brushwhite, star1.path7);
            g.FillPath(brushwhite, star2.path7);
            g.FillPath(brushwhite, star3.path7);
            g.FillPath(brushwhite, star4.path7);
            g.FillPath(brushwhite, star5.path7);
            g.FillPath(brushwhite, star6.path7);
            g.FillPath(brushwhite, star7.path7);
            g.FillPath(brushwhite, star8.path7);

            g.FillPath(brushred, myaster1.path1);
            g.FillPath(brushred, myaster1.path2);
            g.FillPath(brushred, myaster2.path1);
            g.FillPath(brushred, myaster2.path2);
            g.FillPath(brushred, myaster3.path1);
            g.FillPath(brushred, myaster3.path2);
            g.FillPath(brushred, myaster4.path1);
            g.FillPath(brushred, myaster4.path2);

            g.FillPath(brushyellow, ship.path3);

            g.FillPath(brushgreen, gun.path4);
            g.FillPath(brushgreen, bullet.path5);
            g.FillPath(brushgreen, bullet.path6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
