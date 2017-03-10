using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NMySnake.Model
{
    [Serializable]
    public class Point
    {
        public int x;
        public int y;

        public Point() { }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}