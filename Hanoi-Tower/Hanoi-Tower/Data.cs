using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Tower
{
    class Data
    {
        public List<List<int>> Towers;
        public Data(int discN, int towerToBeFilled) //creating the 3 towers, taking 2 parameters(disc number, start tower)
        {
            Towers = new List<List<int>>()
            {
                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            Towers[towerToBeFilled - 1] = FillTower(discN); //indexth start tower fill with the discs
        }

        private List<int> FillTower(int discs)  // this function returns the disc filled start tower, takes 1 parameter(disc number)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < discs; i++)
                temp.Add(i);
            return temp;
        }
    }

}
