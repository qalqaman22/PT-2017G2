using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    class MyAsters
    {
        public GraphicsPath path1 = new GraphicsPath();
        public GraphicsPath path2 = new GraphicsPath();
        public MyAsters(int x, int y)
        {
            Point[] points1 =
             {
                new Point(x,y-30),
                new Point(x+30,y+15),
                new Point(x-30,y+15)
            };
            Point[] points2 =
            {
                new Point(x-30,y-15),
                new Point(x+30,y-15),
                new Point(x,y+30)
            };

            path1.AddPolygon(points1);
            path2.AddPolygon(points2);
        }
    }
}
