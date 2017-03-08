using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace NMySnake.Model
{
    [Serializable]
    public class Snake : Drawer
    {
        public static int cnt = 2;
        public Snake() { }
        public Snake(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body) { }


        public void Move(int dx, int dy)
        {

            delete();

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;

            }

            body[0].x += dx;
            body[0].y += dy;


            NewFood();
            Border();
            NewLevel();
            CollisionWall();
            CollisionSnake();

        }

        public void CollisionWall()
        {
            for (int i = 0; i < Game.wall.body.Count; i++)
            {

                if (Game.snake.body[0].x == Game.wall.body[i].x && Game.snake.body[0].y == Game.wall.body[i].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 20);
                    Console.WriteLine("GAME OVER!");
                    // Console.ReadKey();
                    Game.GameOver = true;

                }
            }
        }


        public void CollisionSnake()
        {
            for (int i = 1; i < Game.snake.body.Count; i++)
            {

                if (Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 20);
                    Console.WriteLine("GAME OVER!");
                    // Console.ReadKey();
                    Game.GameOver = true;

                }
            }
        }
        public void NewFood()
        {
            if (Game.snake.CanEat(Game.food))
            {
                Game.food.SetRandomPosition();
            }
        }
        public void NewLevel()
        {

            if (body.Count == 4)
            {

                Game.wall.LoadLevel(2);
                //Again();

            }

            if (body.Count == 8)
            {

                Game.wall.LoadLevel(3);
                //Again();
            }

        }

        public void Border()
        {
            if (body[0].x > Console.WindowWidth)
                body[0].x = 0;
            if (body[0].x < 0)
                body[0].x = Console.WindowWidth;

            if (body[0].y > Console.WindowHeight)
                body[0].y = 0;
            if (body[0].y < 0)
                body[0].y = Console.WindowHeight;

        }

        public bool CanEat(Food f)
        {
            if (body[0].x == f.body[0].x && body[0].y == f.body[0].y)
            {
                cnt++;
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));

                return true;
            }
            return false;
        }

        public void delete()
        {


            Console.SetCursorPosition(body[body.Count() - 1].x, body[body.Count() - 1].y);

            Console.Write(" ");

        }

        public void Again()
        {
            //List<Point> snake_body = new List<Point>();
            //body.Clear();
            //List<Point> snake_body = new List<Point>();
            //snake_body.Add(new Point(10, 10));

            //snake_body.Add(new Point(9, 10));
            //Console.SetCursorPosition(10, 10);
            //Game.snake = new Snake(Game.snake.body);

        }
    }
}