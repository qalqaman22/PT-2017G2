using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MySnake
{
    [Serializable]
    class Snake
    {
        public List<Point> body;
        public char sign = '0';
        public ConsoleColor color;
        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            color = ConsoleColor.Yellow;

        }

        public void Move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
            if (body[0].x > Console.WindowWidth - 1)
                body[0].x = 0;
            if (body[0].x < 0)
                body[0].x = Console.WindowWidth - 1;

            if (body[0].y > Console.WindowHeight)
                body[0].y = 0;
            if (body[0].y < 0)
                body[0].y = Console.WindowHeight;

            //Eat();
            CollisionWithWallAndSnake();
            if (body.Count == 3)
            {
                Game.wall.Wall2();
            }
            if (body.Count == 5)
            {
                Game.wall.Wall3();
            }
            Eat();
        }

        public void CollisionWithWallAndSnake()
        {
            for (int i = 2; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                {
                    Game.GameO();
                    Game.GameOver = true;

                }
            }
            for (int i = 0; i < Game.wall.body.Count; i++)
            {
                if (body[0].x == Game.wall.body[i].x && body[0].y == Game.wall.body[i].y)
                {
                    Game.GameO();
                    Game.GameOver = true;
                }
            }
            
        }

        public void Eat()
        {
            if (body[0].x == Game.food.location.x && body[0].y == Game.food.location.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                Game.food.SetRandomPosition();
            }
            
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public void save()
        {
            FileStream fs = new FileStream("snake.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public void deser()
        {
            FileStream fs = new FileStream("snake.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Snake snake = bf.Deserialize(fs) as Snake;
            this.body = snake.body;
            this.color = snake.color;
            this.sign = snake.sign;


            fs.Close();
        }
    }
}