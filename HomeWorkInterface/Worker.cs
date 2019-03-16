using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Worker : IWorker
    {
        House standartHouse = new House();
        public void Working()
        {
            Console.WriteLine("Строитель начал работу");
        }
        public void WorkingForPart(string name)
        {
            Console.WriteLine($"Строитель делает {name}");
        }
    }
}
