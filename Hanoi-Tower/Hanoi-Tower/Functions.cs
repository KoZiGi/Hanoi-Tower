using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Tower
{
    class Functions
    {
        private Data data;  //basic info about the game like start tower, disc number
        private int To;     //index of target tower
        public Functions(Data GameData, int to)
        {
            this.To = to;
            data = GameData;
        }

        private bool winCheck(int discN) //if this method returns true then the array is correct and the player wins
        {
            bool check = true;
            for (int i = 0; i < discN; i++) if (data.Towers[To][i] != discN - i) check = false;
            return check;
        }
    }
}
