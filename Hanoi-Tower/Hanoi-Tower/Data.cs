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
        public Data(int discN, int towerToBeFilled)
        {
            Towers = new List<List<int>>()
            {
                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            Towers[towerToBeFilled - 1] = FillTower(discN);
        }

        private List<int> FillTower(int discs)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < discs; i++)
                temp.Add(i);
            return temp;
        }
    }

}
