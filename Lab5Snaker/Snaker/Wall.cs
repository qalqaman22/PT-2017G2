using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MySnake
{
    [Serializable]
    class Wall
    {
        public List<Point> body;
        public char sign = 'o';
        public ConsoleColor color;

        public Wall()
        {
            body = new List<Point>();
            color = ConsoleColor.Red;

            StreamReader sr = new StreamReader("wall1.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                String s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
                }
            }
            sr.Close();
        }
        public void Wall2()
        {
            body = new List<Point>();
            color = ConsoleColor.Red;

            StreamReader sr = new StreamReader("wall2.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                String s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
                }
            }
            sr.Close();
        }
        public void Wall3()
        {
            body = new List<Point>();
            color = ConsoleColor.Red;

            StreamReader sr = new StreamReader("wall3.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                String s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
                }
            }
            sr.Close();
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
            FileStream fs = new FileStream("wall.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public void deser()
        {
            FileStream fs = new FileStream("wall.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Wall wall = bf.Deserialize(fs) as Wall;
            this.body = wall.body;
            this.color = wall.color;
            this.sign = wall.sign;
            fs.Close();
        }
    }
}