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
            checkWin();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b2.Text = "X";
            else
                b2.Text = "O";

            b2.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b3.Text = "X";
            else
                b3.Text = "O";

            b3.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b4.Text = "X";
            else
                b4.Text = "O";

            b4.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b5.Text = "X";
            else
                b5.Text = "O";

            b5.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b6.Text = "X";
            else
                b6.Text = "O";

            b6.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b7.Text = "X";
            else
                b7.Text = "O";

            b7.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b8.Text = "X";
            else
                b8.Text = "O";

            b8.Enabled = false;
            changeTurn();
            checkWin();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b9.Text = "X";
            else
                b9.Text = "O";

            
            b9.Enabled = false;
            changeTurn();
            checkWin();
        }
        //a method to check if the game has ended 
        private void checkWin()
        {
            if (b1.Text != "" && b2.Text != "" && b3.Text != "")
            {
                if (b1.Text == b2.Text && b1.Text == b3.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    if (b1.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                    }
                    clearGame();

                }
            }
            if (b4.Text != "" && b5.Text != "" && b6.Text != "")
            {
                if (b4.Text == b5.Text && b4.Text == b6.Text)
                {
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    if (b4.Text == "X")
                    {
                        MessageBox.Show("You Win!");

                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");

                    }
                    clearGame();
                }
            }
            if (b7.Text != "" && b8.Text != "" && b9.Text != "")
            {
                if (b7.Text == b8.Text && b7.Text == b9.Text)
                {
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b8.BackColor = Color.Green;
                    b8.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    if (b7.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");

                    }
                    clearGame();
                }
            }
            if (b1.Text != "" && b4.Text != "" && b7.Text != "")
            {
                if (b1.Text == b4.Text && b1.Text == b7.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    if (b1.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");

                    }
                    clearGame();
                }
            }
            if (b2.Text != "" && b5.Text != "" && b8.Text != "")
            {
                if (b2.Text == b5.Text && b2.Text == b8.Text)
                {
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b8.BackColor = Color.Green;
                    b8.ForeColor = Color.White;
                    if (b2.Text == "X")
                    {
                        MessageBox.Show("You Win!");

                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");

                    }
                    clearGame();
                }
            }
            if (b3.Text != "" && b6.Text != "" && b9.Text != "")
            {
                if (b3.Text == b6.Text && b3.Text == b9.Text)
                {
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    if (b3.Text == "X")
                    {
                        MessageBox.Show("You Win!");

                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");

                    }
                    clearGame();
                }
            }
            if (b1.Text != "" && b5.Text != "" && b9.Text != "")
            {
                if (b1.Text == b5.Text && b1.Text == b9.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    if (b1.Text == "X")
                    {
                        MessageBox.Show("You Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Compuetr Wins!");

                    }
                    clearGame();
                }
            }
            if (b3.Text != "" && b5.Text != "" && b7.Text != "")
            {
                if (b3.Text == b5.Text && b3.Text == b7.Text)
                {
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    if (b3.Text == "X")
                    {
                        MessageBox.Show("You Win!");

                    }
                    else
                    {
                        MessageBox.Show("Compuetr Wins!");

                    }
                    clearGame();
                }
            }
             if (b1.Text != "" && b2.Text != "" && b3.Text != "" && 
                 b4.Text != "" && b5.Text != "" && b6.Text != "" &&
                 b7.Text != "" && b8.Text != "" && b9.Text != "")
             {
                 MessageBox.Show("Draw!");
                 clearGame();
             }

        }
        // a method to reset the game after a plater has won
        private void clearGame()
        {
            //reset turn back to 1 so 'X' always starts
            turn = 1;

            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";

            b1.BackColor = Color.Empty;
            b1.ForeColor = Color.Black;
            b1.UseVisualStyleBackColor = true;
            b2.BackColor = Color.Empty;
            b2.ForeColor = Color.Black;
            b2.UseVisualStyleBackColor = true;
            b3.BackColor = Color.Empty;
            b3.ForeColor = Color.Black;
            b3.UseVisualStyleBackColor = true;
            b4.BackColor = Color.Empty;
            b4.ForeColor = Color.Black;
            b4.UseVisualStyleBackColor = true;
            b5.BackColor = Color.Empty;
            b5.ForeColor = Color.Black;
            b5.UseVisualStyleBackColor = true;
            b6.BackColor = Color.Empty;
            b6.ForeColor = Color.Black;
            b6.UseVisualStyleBackColor = true;
            b7.BackColor = Color.Empty;
            b7.ForeColor = Color.Black;
            b7.UseVisualStyleBackColor = true;
            b8.BackColor = Color.Empty;
            b8.ForeColor = Color.Black;
            b8.UseVisualStyleBackColor = true;
            b9.BackColor = Color.Empty;
            b9.ForeColor = Color.Black;
            b9.UseVisualStyleBackColor = true;

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
        }
    }
}
