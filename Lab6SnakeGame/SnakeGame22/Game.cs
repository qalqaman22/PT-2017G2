using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace MySnake
{
    [Serializable]
    class Game
    {
        public static bool GameOver = false;
        public static Snake snake = new Snake();
        public static Wall wall = new Wall();
        public static Food food = new Food();
        public static int d = 2;

        public static void Init()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("Press any key to start");
            Console.SetCursorPosition(23, 11);
            Console.WriteLine("...............");
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("GOOD LUCK");
            Console.ReadKey();
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 40);
        }
        public static void Server()
        {
            Thread t = new Thread(ThreadSnake);
            t.Start();

            while (!Game.GameOver)
            {
                //Game.Draw();
                ConsoleKeyInfo pressed = Console.ReadKey();

                if (pressed.Key == ConsoleKey.UpArrow)
                    d = 1;
                //Game.snake.Move(0, -1);
                if (pressed.Key == ConsoleKey.DownArrow)
                    d = 2;
                //Game.snake.Move(0, 1);
                if (pressed.Key == ConsoleKey.LeftArrow)
                    d = 3;
                //Game.snake.Move(-1, 0);
                if (pressed.Key == ConsoleKey.RightArrow)
                    d = 4;
                //Game.snake.Move(1, 0);

                if (pressed.Key == ConsoleKey.F2)
                    Game.Save();
                if (pressed.Key == ConsoleKey.F3)
                    Game.Resume();
                if (pressed.Key == ConsoleKey.Escape)
                    Game.GameOver = true;
            }
        }

        public static void Draw()
        {
            Console.Clear();
            snake.Draw();
            wall.Draw();
            food.Draw();
        }

        public static void Save()
        {
            Game.snake.save();
            Game.wall.save();
            Game.food.save();
            // serialize all objects
        }

        public static void Resume()
        {
            Console.Clear();
            Game.snake.deser();
            Game.wall.deser();
            Game.food.deser();
            // deserialize all objects
        }
        public static void GameO()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("GAME OVER!");
            Console.SetCursorPosition(28, 16);
            Console.WriteLine("NEVER GIVE UP!");
            Console.ReadKey();
        }
        public static void ThreadSnake()
        {
            while (!Game.GameOver)
            {
                Game.Draw();
                Thread.Sleep(100);
                int b = 500;
                if (snake.body.Count % 10 == 0)
                {
                    Thread.Sleep(b);
                    b -= 100;
                }
                switch (d)
                {
                    case 1:
                        Game.snake.Move(0, -1);
                        break;
                    case 2:
                        Game.snake.Move(0, 1);
                        break;
                    case 3:
                        Game.snake.Move(-1, 0);
                        break;
                    case 4:
                        Game.snake.Move(1, -0);
                        break;
                }
            }
        }
    }
}