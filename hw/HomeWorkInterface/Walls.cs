using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Walls : IPart
    {
        House standartHouse = new House();
        public int walls = 0;
        public string name;
        public Walls()
        {
            name = "стена";
        }

        public void Builds()
        {
            walls++;
            //Console.WriteLine($"Возвели {walls} стены");
            //if (walls == standartHouse._standartWalls)
            //    Console.WriteLine("Все стены возвели");
        }
    }
}
