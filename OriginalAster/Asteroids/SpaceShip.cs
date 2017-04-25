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
        public GraphicsPath path11 = new GraphicsPath();
        public GraphicsPath path12 = new GraphicsPath();
        public GraphicsPath path13 = new GraphicsPath();
        public GraphicsPath path14 = new GraphicsPath();
        public GraphicsPath path15 = new GraphicsPath();
        public GraphicsPath path16 = new GraphicsPath();
        public GraphicsPath path17 = new GraphicsPath();
        public GraphicsPath path18 = new GraphicsPath();
        
        public SpaceShip(int x,int y)
        {
            
            Point[] polypoints =
            {
                new Point(x,y-30),
                new Point(x+30,y-15),
                new Point(x+30,y+15),
                new Point(x,y+30),
                new Point(x-30,y+15),
                new Point(x-30,y-15)
            };

            Point[] polypoints1 =
            {
                new Point(x,y-5),
                new Point(x+10,y+5),
                new Point(x-10,y+5),
                
            };
            Point[] polypoints2 =
            {
                new Point(x-5,y-5),
                new Point(x+5,y-5),
                new Point(x+5,y+5),
            };
            Point[] polypoints3 =
            {
                new Point(x-5,y-10),
                new Point(x+5,y),
                new Point(x-5,y+10),
            };
            Point[] polypoints4 =
            {
                new Point(x+5,y-5),
                new Point(x+5,y+5),
                new Point(x-5,y+5),
            };
            Point[] polypoints5 =
            {
                new Point(x-10,y-5),
                new Point(x+10,y-5),
                new Point(x,y+5),
            };
            Point[] polypoints6 =
            {
                new Point(x+5,y+5),
                new Point(x-5,y+5),
                new Point(x-5,y-5),
            };
            Point[] polypoints7 =
            {
                new Point(x+5,y-10),
                new Point(x+5,y+10),
                new Point(x-5,y),
            };
            Point[] polypoints8 =
            {
                new Point(x+5,y-5),
                new Point(x-5,y+5),
                new Point(x-5,y-5),
            };

            path3.AddPolygon(polypoints);
            path11.AddPolygon(polypoints1);
            path12.AddPolygon(polypoints2);
            path13.AddPolygon(polypoints3);
            path14.AddPolygon(polypoints4);
            path15.AddPolygon(polypoints5);
            path16.AddPolygon(polypoints6);
            path17.AddPolygon(polypoints7);
            path18.AddPolygon(polypoints8);
        }
    }
}
