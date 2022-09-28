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
        public int DiscN;
        public int From;
        public int To;
        public Data(int from, int to, int discN)
        {
            From = from;
            To = to;
            DiscN = discN;
            Towers = new List<List<int>>()
            {
                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            Towers[from-1] = FillTower(discN);
        }

        private List<int> FillTower(int discs)  // this function returns the disc filled start tower, takes 1 parameter(disc number)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < discs; i++)
                temp.Add(discs-i);
            return temp;
        }
    }

}
