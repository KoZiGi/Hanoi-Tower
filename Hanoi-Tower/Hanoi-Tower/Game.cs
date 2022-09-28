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
            data = new Data(korong, from);
            dummyDisplay();
            functions = new Functions(data,to);
        }

        private void dummyDisplay()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = data.Towers[0].Count-1; i >= 0; i--)
            {
                listBox1.Items.Add(data.Towers[0][i]);
            }
            for (int i = data.Towers[1].Count-1; i >= 0; i--)
            {
                listBox2.Items.Add(data.Towers[1][i]);
            }
            for (int i = data.Towers[2].Count-1; i >= 0; i--)
            {
                listBox3.Items.Add(data.Towers[2][i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            functions.Move(Convert.ToInt32(numericUpDown1.Value)-1, Convert.ToInt32(numericUpDown2.Value)-1);
            dummyDisplay();
        }
    }
}
