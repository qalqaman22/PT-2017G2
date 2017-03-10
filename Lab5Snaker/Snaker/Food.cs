using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MySnake
{
    [Serializable]
    class Food
    {
        public Point location;
        public ConsoleColor color;
        public char sign;

        public Food()
        {
            color = ConsoleColor.Green;
            sign = '$';
            SetRandomPosition();
        }
        public void Wallfood()
        {
            for (int i = 0; i < Game.wall.body.Count; i++)
            {
                if (location.x == Game.wall.body[i].x && location.y == Game.wall.body[i].y)
                {
                    SetRandomPosition();
                }
            }
        }
        public void SetRandomPosition()
        {

            int x = new Random().Next(0, 80);
            int y = new Random().Next(0, 40);
            // Is "x" and "y" on the wall or on the snake? If so, regenerate new position.

            location = new Point(x, y);
            Wallfood();
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.Write(sign);
        }
        public void save()
        {
            FileStream fs = new FileStream("food.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public void deser()
        {
            FileStream fs = new FileStream("food.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Food food = bf.Deserialize(fs) as Food;
            this.location = food.location;
            this.color = food.color;
            this.sign = food.sign;


            fs.Close();
        }
    }
}