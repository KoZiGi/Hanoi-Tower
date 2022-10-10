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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Icon = Properties.Resources.vodor1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == numericUpDown3.Value)   //error check, the start and the destination tower cant be the same
            {
                MessageBox.Show("Nem egyezhet a két oszlop","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Game gamm = new Game(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));
                gamm.Show();
            }
        }
    }
}
