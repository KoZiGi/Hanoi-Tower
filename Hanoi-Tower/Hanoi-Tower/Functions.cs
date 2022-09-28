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
        private int To;     //index of destination tower
        public Functions(Data GameData, int to)
        {
            this.To = to;
            data = GameData;
        }

        private bool winCheck(int discN) //if this method returns true then the array is correct and the player wins, takes one parameter(disc number)
        {
            bool check = true;
            for (int i = 0; i < discN; i++) if (data.Towers[To][i] != discN - i) check = false;
            return check;
        }
       
        public void Move(int start, int dest)   // disc move and compatibility check, takes 2 parameter(start tower index, destination tower index)
        {
            if (data.Towers[dest][data.Towers[dest].Count - 1] > data.Towers[start][data.Towers[start].Count - 1]|| data.Towers[dest].Count==0)
            {
                data.Towers[dest].Add(data.Towers[start][data.Towers[start].Count - 1]);    //add the chosen disc to the destination tower
                data.Towers[start].RemoveAt(data.Towers[start].Count-1);            //remove the chosen disc from its start tower
            }
        }


    }
}
