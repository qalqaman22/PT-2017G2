using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    class SpaceShip
    {
        public GraphicsPath path3 = new GraphicsPath();
        //public GraphicsPath path4 = new GraphicsPath();
        public SpaceShip(int x,int y)
        {
            
            Point[] polypoints1 =
            {
                new Point(x,y-60),
                new Point(x+60,y-30),
                new Point(x+60,y+30),
                new Point(x,y+60),
                new Point(x-60,y+30),
                new Point(x-60,y-30)
            };

            /*
            Point[] polypoints2 =
            {
                new Point(x-20,y-10),
                new Point(x,y-30),
                new Point(x+20,y-10),
                new Point(x+6,y-10),
                new Point(x+6,y+30),
                new Point(x-6,y+30),
                new Point(x-6,y-10)
            };
            */
            
            path3.AddPolygon(polypoints1);
            //path4.AddPolygon(polypoints2);
        }
    }
}
