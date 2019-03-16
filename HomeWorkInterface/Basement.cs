using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Basement : IPart
    {
        House standartHouse = new House();
        public int basement = 0;
        public string name;
        public Basement()
        {
            name = "фунамент";
        }

        public void Builds()
        {
            basement++;
            //if(basement == standartHouse._standartBasement)
            //Console.WriteLine("Фундамент залили");
        }
    }
}
