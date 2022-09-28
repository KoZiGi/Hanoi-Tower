using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Tower
{
    class Functions
    {
        private Data data; //basic info about the game like start tower, disc number
        private int To; //index of target tower
        public Functions(Data GameData, int to)
        {
            data = GameData;
            To = to;
        }
        public List<Panel> GenPanels()
        {
            List<Panel> towers = GenTowers();
            List<Panel> discs = GenDiscs();
            towers.AddRange(discs);
            return towers;
        }
        private List<Panel> GenDiscs()
        {
            List<Panel> discs = new List<Panel>();
            for (int i = 0; i < data.DiscN; i++)
                discs.Add(GenDisc(i+1, 10, i));
            return discs;
        }
        public List<Label> GenTowerLabels()
        {
            List<Label> labels = new List<Label>();
            for (int i = 1; i < 4; i++)
                GenLabel($"Tower{i}Lbl", i);
            return labels;
        }
        private Label GenLabel(string text, int x)
        {
            return new Label()
            {
                Text = GetWhich(text),
                Name = text,
                Left = x * 50,
                Top = data.DiscN * 15 + 20,
                BackColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 12)

            };
        }
        private string GetWhich(string text)
        {
            switch (text)
            {
                case "Tower1Lbl":
                    return "A";
                case "Tower2Lbl":
                    return "B";
                default:
                    return "C";
            }
        }
        private Panel GenDisc(int width, int height, int DiscN)
        {
            return new Panel()
            {
                Name = $"Disc{DiscN}",
                Top = 10 + (DiscN * 15),
                Left = ((data.DiscN-DiscN)*(100/data.DiscN)/2)+((data.From)*100),
                Width = (100/data.DiscN)*width,
                Height = height,
                BackColor = Color.FromArgb(250,50,250)
            };
        }
        private List<Panel> GenTowers()
        {
            List<Panel> towers = new List<Panel>();
            for (int i = 1; i < 4; i++)
                towers.Add(GenTower(10, data.DiscN * 15, i));
            return towers;

        private bool winCheck(int discN) //if this method returns true then the array is correct and the player wins
        {
            if (data.Towers[To].Count == discN) return true;
            else return false;
        }
        private Panel GenTower(int width, int height, int towerN)
        {
            return new Panel()
            {
                Width = width,
                Height = height,
                Left = towerN * 100,
                Top = 10,
                Name = $"tower{towerN}",
                BackColor = Color.Black
            };
        }
        public void Display(List<Panel> discs)
        {

            foreach (List<int> list in data.Towers)
            {
                foreach (int disc in list)
                {
                    
                }
            }
        }
    }
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
