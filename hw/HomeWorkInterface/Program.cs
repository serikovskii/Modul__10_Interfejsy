using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House();
            var team = new Team();
            var teamLeader = new TeamLeader();
            var worker = new Worker();
            var roof = new Roof();
            var door = new Door();
            var window = new Window();
            var walls = new Walls();
            var basement = new Basement();
            int choice;

            team.Working();
            worker.Working();

            do
            {
                if(house._standartBasement != basement.basement)
                {
                    worker.WorkingForPart(basement.name);
                    basement.Builds();
                }
                else if (house._standartBasement == basement.basement && house._standartWalls !=walls.walls)
                {
                    worker.WorkingForPart(walls.name);
                    walls.Builds();
                }
                else if ((house._standartBasement == basement.basement && house._standartWalls == walls.walls) && house._standartRoof != roof.roof)
                {
                    worker.WorkingForPart(roof.name);
                    roof.Builds();
                    Console.WriteLine("--------------");
                    teamLeader.Working();
                    teamLeader.WritesReport(basement.basement, walls.walls, door.door, window.winodws, roof.roof);
                    Console.WriteLine("--------------");
                    Console.WriteLine("Нажмите 1 - для продолжения и 2 для выхода");
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1)
                        continue;
                    else
                        break;
                }
                else if ((house._standartBasement == basement.basement && house._standartWalls == walls.walls && house._standartRoof == roof.roof)
                          && house._standartWindows != window.winodws)
                {
                    worker.WorkingForPart(window.name);
                    window.Builds();
                }
                else if ((house._standartBasement == basement.basement && house._standartWalls == walls.walls && house._standartRoof == roof.roof
                          && house._standartWindows == window.winodws) && house._standartDoor != door.door)
                {
                    worker.WorkingForPart(door.name);
                    door.Builds();
                    house.CheckBuilds(basement.basement, walls.walls, door.door, window.winodws, roof.roof);
                }
            }
            while (!house._houseBuild);
        }
    }
}
