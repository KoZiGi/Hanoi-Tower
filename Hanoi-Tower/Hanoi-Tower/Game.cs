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
            data = new Data(from,to,korong);
            functions = new Functions(data);
            InitDisplay();
            
        }
        private void InitDisplay()
        {
            foreach (Panel p in functions.GenPanels())
                Controls.Add(p);
            foreach (Panel p in Controls)
                if (p.Name.Contains("Disc"))
                    p.BringToFront();
            foreach (Label l in functions.GenTowerLabels())
                Controls.Add(l);
        }

    }
}
