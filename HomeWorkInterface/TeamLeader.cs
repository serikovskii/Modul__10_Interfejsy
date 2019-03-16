using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class TeamLeader : IWorker
    {
        House standartHouse = new House();
        public void Working()
        {
            Console.WriteLine("Бригадир формирует отчет:");
        }
        public void WritesReport(int basement, int walls, int door, int window, int roof)
        {
            if(standartHouse._standartBasement == basement)
            {
                Console.WriteLine("Залили фундамент");
                if(standartHouse._standartWalls == walls)
                {
                    Console.WriteLine("Возвели все стены");
                    if(standartHouse._standartRoof == roof)
                    {
                        Console.WriteLine("Установили крышу");
                        if(standartHouse._standartWindows == window)
                        {
                            Console.WriteLine("Установили все окна");
                            if (standartHouse._standartDoor == door)
                            {
                                Console.WriteLine("Установили дверь");
                                standartHouse.Builds();
                            }
                            else
                                Console.WriteLine("Дверь не установлена");
                        }
                        else
                            Console.WriteLine($"Установили {window} окна");
                    }
                    else
                        Console.WriteLine("Крыша не установлена");
                }
                else
                    Console.WriteLine($"Возвели {walls} стены");
            }
            else
                Console.WriteLine("Фундамент не залит");
        }

    }
}
