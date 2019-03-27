using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Window : IPart
    {
        House standartHouse = new House();
        public int winodws = 0;
        public string name;
        public Window()
        {
            name = "окно";
        }

        public void Builds()
        {
            winodws++;
            //Console.WriteLine($"Установили {winodws} окна");
            //if (winodws == standartHouse._standartWindows)
            //    Console.WriteLine("Все окна установили");
        }
    }
}
