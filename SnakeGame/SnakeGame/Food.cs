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
    public class Food : Drawer
    {

        public Food() { }
        public Food(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body)
        {
            SetRandomPosition();

        }

        public void SetRandomPosition()
        {

            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 35);


            body[0] = new Point(x, y);

            CollesionSnakeAndWall(body[0]);



        }

        public void CollesionSnakeAndWall(Point p)
        {
            for (int i = 0; i < Game.wall.body.Count; i++)
            {

                if (p.x == Game.wall.body[i].x && p.y == Game.wall.body[i].y)
                {
                    SetRandomPosition();
                }
            }

            for (int i = 0; i < Game.snake.body.Count; i++)
            {

                if (p.x == Game.snake.body[i].x && p.y == Game.snake.body[i].y)
                {
                    SetRandomPosition();
                }
            }

        }
        
    }
}
