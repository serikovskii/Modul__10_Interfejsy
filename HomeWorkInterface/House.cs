using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkInterface
{
    public class House : IPart
    {
        public int _standartBasement;
        public int _standartWalls;
        public int _standartDoor;
        public int _standartWindows;
        public int _standartRoof;
        public bool _houseBuild;
        public House()
        {
            _standartBasement = 1;
            _standartWalls = 4;
            _standartRoof = 1;
            _standartWindows = 4;
            _standartDoor = 1;
            _houseBuild = false;
        }
        public void Builds()
        {
            Console.WriteLine("Дом построился");
        }

        public void CheckBuilds(int basement, int walls, int door, int window, int roof)
        {
            if(_standartBasement == basement && _standartWalls == walls && _standartRoof == roof && _standartDoor == door && _standartWindows == window)
            {
                Builds();
                _houseBuild = true;
            }
        }
    }
}
