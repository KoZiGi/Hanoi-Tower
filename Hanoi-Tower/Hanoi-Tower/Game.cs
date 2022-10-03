using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            data = new Data(from, to, korong);
            functions = new Functions(data,to);
            InitDisplay();
        }

        private void InitDisplay()
        {
            foreach (Panel p in functions.GenPanels())
                Controls.Add(p);
            foreach (Label l in functions.GenTowerLabels())
                Controls.Add(l);
            foreach (Control l in Controls)
            {
                if (l.Name.Contains("Lbl"))
                {
                    l.Click += functions.TowerClick;
                }
            }
        }

    }
}
