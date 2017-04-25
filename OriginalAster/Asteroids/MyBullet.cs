using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class MyBullet
    {
        Graphics g;
        SolidBrush green = new SolidBrush(Color.Green);
        Point bul;
        int c;
        int xCoor;
        int yCoor;
        
        public MyBullet(Graphics g, Point bul, int c)
        {
            this.g = g;
            this.bul = bul;
            this.c = c;
        }

        public int getX()
        {
            return xCoor;
        }
        public int getY()
        {
            return yCoor;
        }

        public void BulDraw(Graphics g)
        {
            g.FillEllipse(green, bul.X - 3, bul.Y - 8, 6, 16);
            g.FillEllipse(green, bul.X - 8, bul.Y - 3, 16, 6);
        }

        public void BulMove(List<MyBullet> bullet)
        {

            switch (c)
            {
                case 1:
                    bul.Y -= 11;
                    break;
                case 2:
                    bul.X += 8;
                    bul.Y -= 8;
                    break;
                case 3:
                    bul.X += 11;
                    break;
                case 4:
                    bul.X += 8;
                    bul.Y += 8;
                    break;
                case 5:
                    bul.Y += 11;
                    break;
                case 6:
                    bul.X -= 8;
                    bul.Y += 8;
                    break;
                case 7:
                    bul.X -= 11;
                    break;
                case 8:
                    bul.X -= 8;
                    bul.Y -= 8;
                    break;
            }
            xCoor = bul.X;
            yCoor = bul.Y;
        }
    }
}