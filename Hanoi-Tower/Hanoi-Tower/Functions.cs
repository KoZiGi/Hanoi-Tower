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
            if (data.Towers[To].Count == discN) return true;
            else return false;
        }
       
        public void Move(int start, int dest) //checks if the move is valid and moves the discs
        {
            if (data.Towers[dest].Count==0)
            {
                data.Towers[dest].Add ( data.Towers[start][data.Towers[start].Count - 1]);
                data.Towers[start].RemoveAt(data.Towers[start].Count - 1);
            }
            else if(data.Towers[dest][data.Towers[dest].Count-1]> data.Towers[start][data.Towers[start].Count - 1])
            {
                data.Towers[dest].Add(data.Towers[start][data.Towers[start].Count - 1]);
                data.Towers[start].RemoveAt(data.Towers[start].Count - 1);
            }
        }
    }
}
