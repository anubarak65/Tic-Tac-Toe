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
    public partial class Grid3 : Form
    {
        /*an integer to determine the players turn.
         * 1 correspons to 'X' and 0 to 'O'
         *'X' alwasys starts first
         */
        private int turn = 1;

        public Grid3()
        {
            InitializeComponent();
        }
        // a method to change the players turn
        private void changeTurn()
        {
            if (turn == 1)
                turn = 0;
            else
                turn = 1;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b1.Text = "X";
            else
                b1.Text = "O";

            b1.Enabled = false;
            changeTurn();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b2.Text = "X";
            else
                b2.Text = "O";

            b2.Enabled = false;
            changeTurn();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b3.Text = "X";
            else
                b3.Text = "O";

            b3.Enabled = false;
            changeTurn();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b4.Text = "X";
            else
                b4.Text = "O";

            b4.Enabled = false;
            changeTurn();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b5.Text = "X";
            else
                b5.Text = "O";

            b5.Enabled = false;
            changeTurn();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b6.Text = "X";
            else
                b6.Text = "O";

            b6.Enabled = false;
            changeTurn();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b7.Text = "X";
            else
                b7.Text = "O";

            b7.Enabled = false;
            changeTurn();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b8.Text = "X";
            else
                b8.Text = "O";

            b8.Enabled = false;
            changeTurn();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b9.Text = "X";
            else
                b9.Text = "O";

            b9.Enabled = false;
            changeTurn();
        }
        //a method to check if the game has ended 
        private void checkWin()
        {

        }
    }
}
