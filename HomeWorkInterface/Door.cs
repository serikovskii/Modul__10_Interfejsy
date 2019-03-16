using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Door : IPart
    {
        House standartHouse = new House();
        public int door = 0;
        public string name;
        public Door()
        {
            name = "дверь";
        }

        public void Builds()
        {
            door++;
            //if (door == standartHouse._standartDoor)
            //    Console.WriteLine("Дверь установили");
        }
    }
}
