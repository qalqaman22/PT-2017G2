using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    class MyGun
    {
        public GraphicsPath path4 = new GraphicsPath();
        public MyGun(int x, int y)
        {
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
            path4.AddPolygon(polypoints2);
        }
    }
}
