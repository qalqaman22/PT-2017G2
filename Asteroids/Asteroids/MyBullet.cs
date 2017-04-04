using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    class MyBullet
    {
        public GraphicsPath path5 = new GraphicsPath();
        public GraphicsPath path6 = new GraphicsPath();
        public MyBullet(int x,int y)
        {
            path5.AddEllipse(x-5, y-13, 10, 26);
            path6.AddEllipse(x-13, y-5, 26, 10);
        }
    }
}
