using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Asteroids
{
    class MyStars
    {
        public GraphicsPath path7 = new GraphicsPath();
        public MyStars(int x,int y)
        {
            path7.AddEllipse(x, y, 35, 35);
        }
    }
}
