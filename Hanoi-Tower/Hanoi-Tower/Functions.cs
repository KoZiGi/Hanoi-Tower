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
            data.Discs = GenDiscs();
            data.TowersP = GenTowers();
            data.Labels = GenTowerLabels();
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
                discs.Add(GenDisc(i+1, 10, i, GenTowers()));
            return discs;
        }
        public List<Label> GenTowerLabels()
        {
            List<Label> labels = new List<Label>();
            for (int i = 1; i < 4; i++)
                labels.Add(GenLabel($"Tower{i}Lbl", i));
            return labels;
        }
        private Label GenLabel(string text, int x)
        {
            return new Label()
            {
                Text = GetWhich(text),
                Name = text,
                AutoSize = true,
                Left = x * 105-6,
                Top = data.DiscN*15 + 20,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 12),
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
        private int GetTower(string text)
        {
            switch (text)
            {
                case "A":
                    return 0;
                case "B":
                    return 1;
                default:
                    return 2;
            }
        }
        private Panel GenDisc(int width, int height, int DiscN, List<Panel> towers)
        {
            return new Panel()
            {
                Name = $"Disc{DiscN}",
                Top = 10 + (DiscN * 15),
                Left = (towers[data.From - 1].Left - ((100 / data.DiscN) * width) / 2) + 5,
                Width = (100 / data.DiscN) * width,
                Height = height,
                BackColor = Color.HotPink
            };
        }
        private List<Panel> GenTowers()
        {
            List<Panel> towers = new List<Panel>();
            for (int i = 1; i < 4; i++)
                towers.Add(GenTower(10, data.DiscN * 15, i));
            return towers;
        }
        private bool winCheck() //if this method returns true then the array is correct and the player wins
        {
            if (data.Towers[To-1].Count == data.DiscN) return true;
            else return false;
        }
        private Panel GenTower(int width, int height, int towerN)
        {
            return new Panel()
            {
                Width = width,
                Height = height,
                Left = towerN * 105,
                Top = 10,
                Name = $"tower{towerN}",
                BackColor = Color.Black
            };
        }
        public void Display()
        {
            int i = 0, g = 0;
            foreach (List<int> discs in data.Towers)
            {
                g = 0;
                foreach (int disc in discs)
                {
                    Panel disk = data.Discs.First(x => x.Name == $"Disc{disc - 1}");
                    disk.Left = data.TowersP[i].Left - disk.Width/2 + 5;
                    disk.Top = 10 + ((data.DiscN - g - 1) * 15);
                    g++;
                }
                i++;
            }
        }
        public void ModifyDisc(Panel disc, int index, int height, List<Panel> towers)
        {
            disc.Left = towers[index].Left - (disc.Width/2);
            disc.Top = data.DiscN * 15 - height * 10;
        }
        public void Move(int start, int dest) //checks if the move is valid and moves the discs
        {
            if (data.Towers[start].Count==0)
            {
                MessageBox.Show("pnjiom ");
            }
            else if (data.Towers[dest].Count == 0)
            {
                data.Towers[dest].Add(data.Towers[start][data.Towers[start].Count - 1]);
                data.Towers[start].RemoveAt(data.Towers[start].Count - 1);
            }
            else if (data.Towers[dest][data.Towers[dest].Count - 1] > data.Towers[start][data.Towers[start].Count - 1])
            {
                data.Towers[dest].Add(data.Towers[start][data.Towers[start].Count - 1]);
                data.Towers[start].RemoveAt(data.Towers[start].Count - 1);
            }
            
        }
        public void TowerClick(object sender, EventArgs e)
        {
            Label s = sender as Label;
            s.ForeColor = Color.Red;
            if (!data.selected)
            {
                data.selected = true;
                data.before = s.Text;
            }
            else if (data.selected)
            {
                Move(GetTower(data.before), GetTower(s.Text));
                Display();
                ResetColors();
                if (winCheck())
                {
                    DialogResult g = MessageBox.Show("Gratulálok győztél!", "Győztél", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (g == DialogResult.Yes)
                    {
                        data.f.Show();
                        Game.ActiveForm.Close();
                    }
                       
                    else
                    {
                        MessageBox.Show("Akkor kétségben vonhatatlanul jogomban áll nem itt lenni.");
                        Game.ActiveForm.Close();
                        data.f.Close();
                    }
                }
                data.selected = false;
                data.before = "";
            }
        }
        private void ResetColors()
        {
            foreach (Label l in data.Labels)
            {
                l.ForeColor = Color.Black;
            }
        }
    }
}
