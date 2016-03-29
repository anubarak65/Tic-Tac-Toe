using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grid3 newGrid3 = new Grid3();
            newGrid3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grid5 newGrid5 = new Grid5();
            newGrid5.Show();
        }
    }
}
