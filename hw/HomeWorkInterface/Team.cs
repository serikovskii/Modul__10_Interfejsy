using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class Team : IWorker
    {
        public void Working()
        {
            Console.WriteLine("Бригада начала сторить дом");
        }

    }
}
