using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi_Tower
{
    
    public partial class Game : Form
    {
        private Data data;
        private Functions functions;
        public Game(int korong, int from, int to)
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            data = new Data(from, to, korong);
            functions = new Functions(data,to);
            data.f = Form1.ActiveForm as Form1;
            data.f.Hide();
            this.FormClosing += NeHaljonMeg;
            InitDisplay();
        }
        private void NeHaljonMeg(object sender, EventArgs e)
        {
            data.f.Close();
        }
        private void InitDisplay()
        {
            foreach (Panel p in data.Discs)
                Controls.Add(p);
            foreach (Panel t in data.TowersP)
                Controls.Add(t);
            foreach (Label l in data.Labels)
                Controls.Add(l);
            foreach (Control l in Controls)
            {
                if (l.Name.Contains("Lbl"))  l.Click += functions.TowerClick;
                if (l.Name.Contains("Disc")) l.BringToFront();
            }
        }

    }
}
