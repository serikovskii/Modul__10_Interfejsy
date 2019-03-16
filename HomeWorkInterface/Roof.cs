using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Roof : IPart
    {
        House standartHouse = new House();
        public int roof = 0;
        public string name;
        public Roof()
        {
            name = "крыша";
        }

        public void Builds()
        {
            roof++;
            //if (roof == standartHouse._standartRoof)
            //    Console.WriteLine("Крышу установили");
        }
    }
}
