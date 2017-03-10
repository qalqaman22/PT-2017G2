using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace MySnake
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Game.Init();
            Game.Server();
        }
    }
}