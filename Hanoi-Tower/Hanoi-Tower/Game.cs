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
        static List<int[]> Ruds;
        private static int tallers, begin, end;
        public Game(int korong, int from, int to)
        {
            InitializeComponent();
            begin = from;
            Ruds = new List<int[]>()
            {
                new int[tallers],
                new int[tallers],
                new int[tallers]
            };
            end = to;
            tallers = korong;
        }
        private void ZoeloepEinfuellen()
        {
            switch (begin)
            {
                case 1:
                    Fill(1);
                    break;
                case 2:
                    Fill(2);
                    break;
                case 3:
                    Fill(3);
                    break;
            }
        }
        private int[] Fill(int Ausgewaehlten_ZoeLoep)
        {



            return;
        }
    }
}
