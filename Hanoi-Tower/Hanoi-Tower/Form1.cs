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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == numericUpDown3.Value)
            {
                MessageBox.Show("NEM", "NEM", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Game gamm = new Game(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));
                gamm.Show();
                Hide();
            }
        }


    }
}
