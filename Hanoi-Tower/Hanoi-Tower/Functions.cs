using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Tower
{
    class Functions
    {
        private Data data;
        public Functions(Data Gamedata)
        {
            data = Gamedata;
        }
        public void Move(int start, int dest)
        {
            if (data.Towers[dest][data.Towers[dest].Count - 1] > data.Towers[start][data.Towers[start].Count - 1]|| data.Towers[dest].Count==0)
            {
                data.Towers[dest].Add(data.Towers[start][data.Towers[start].Count - 1]);
                data.Towers[start].RemoveAt(data.Towers[start].Count-1);
            }
        }

    }
}
