using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NMySnake.Model
{
    [Serializable]
    public class Game
    {
        public static int Speed;
        public static int d = 4;
        public static bool GameOver;
        public static Snake snake;
        public static Food food;
        public static Wall wall;

        public Game() { }

        public static void Init()
        {

            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);

            GameOver = false;

            Begin();


            List<Point> wall_body = new List<Point>();
            wall = new Wall(ConsoleColor.Red, '#', wall_body);


            List<Point> snake_body = new List<Point>();
            snake_body.Add(new Point(10, 10));
            snake_body.Add(new Point(9, 10));
            snake = new Snake(ConsoleColor.Yellow, 'o', snake_body);

            List<Point> food_body = new List<Point>();
            food_body.Add(new Point(0, 0));
            food = new Food(ConsoleColor.Green, '$', food_body);



        }

        public static void Move()
        {
            Thread t = new Thread(MoveSnake);
            t.Start();


            while (!GameOver)

            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        d = 1;
                        //Game.snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        //Game.snake.Move(0, 1);
                        d = 2;
                        break;
                    case ConsoleKey.LeftArrow:
                        //Game.snake.Move(-1, 0);
                        d = 3;
                        break;
                    case ConsoleKey.RightArrow:
                        //Game.snake.Move(1, 0);
                        d = 4;

                        break;
                    case ConsoleKey.Escape:
                        GameOver = true;
                        break;
                    case ConsoleKey.F2:
                        Save();
                        break;
                    case ConsoleKey.F3:
                        Resume();
                        break;
                }
            }

        }

        public static void Cnt()
        {
            switch (Wall.Level)
            {
                case 1:
                    Speed = 300;

                    break;
                case 2:
                    Speed = 200;
                    break;
                case 3:
                    Speed = 100;
                    break;
            }
        }


        static void MoveSnake()
        {
            while (!GameOver)

            {
                Draw();
                Cnt();
                Thread.Sleep(Speed);

                switch (d)
                {
                    case 1:

                        snake.Move(0, -1);
                        break;
                    case 2:
                        snake.Move(0, 1);

                        break;
                    case 3:
                        snake.Move(-1, 0);

                        break;
                    case 4:
                        snake.Move(1, 0);

                        break;


                }
            }
        }


        public static void Save()
        {
            snake.save();
            wall.save();
            food.save();

        }
        public static void Resume()
        {
            snake.release();
            wall.release();
            food.release();

        }

        public static void Draw()
        {
            
            snake.Draw();
            food.Draw();
            wall.Draw();
        }

        public static void Begin()
        {
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("WELCOME!");
            Console.SetCursorPosition(15, 18);
            Console.WriteLine("Press any key to start the game ...");
            Console.ReadKey();
        }
    }
}