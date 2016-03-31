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
    public partial class Grid5 : Form
    {
        public Grid5()
        {
            InitializeComponent();
        }
        /*an integer to determine the players turn.
         * 1 correspons to 'X' and 0 to 'O'
         *'X' alwasys starts first
         */
        private int turn = 1;
        private int noTurn = 0;
        /*
        *two integers for keeping track of number of wins  
        */
        private int player = 0;
        private int cp = 0;
        // a method to change the players turn
        private void changeTurn()
        {
            noTurn++;
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
            aiMove();
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
             aiMove();
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
             aiMove();
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
             aiMove();
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
             aiMove();
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
             aiMove();
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
             aiMove();
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
             aiMove();
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
             aiMove();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b10.Text = "X";
            else
                b10.Text = "O";

            b10.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b11.Text = "X";
            else
                b11.Text = "O";

            b11.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b12.Text = "X";
            else
                b12.Text = "O";

            b12.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b13.Text = "X";
            else
                b13.Text = "O";

            b13.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b14.Text = "X";
            else
                b14.Text = "O";

            b14.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b15.Text = "X";
            else
                b15.Text = "O";

            b15.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b16.Text = "X";
            else
                b16.Text = "O";

            b16.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b17_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b17.Text = "X";
            else
                b17.Text = "O";

            b17.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b18.Text = "X";
            else
                b18.Text = "O";

            b18.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b19_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b19.Text = "X";
            else
                b19.Text = "O";

            b19.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b20.Text = "X";
            else
                b20.Text = "O";

            b20.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b21_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b21.Text = "X";
            else
                b21.Text = "O";

            b21.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b22.Text = "X";
            else
                b22.Text = "O";

            b22.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b23_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b23.Text = "X";
            else
                b23.Text = "O";

            b23.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b24_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b24.Text = "X";
            else
                b24.Text = "O";

            b24.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }

        private void b25_Click(object sender, EventArgs e)
        {
            if (turn == 1)
                b25.Text = "X";
            else
                b25.Text = "O";

            b25.Enabled = false;
            changeTurn();
             checkWin();
             aiMove();
        }
        //a method to check if the game has ended 
        private void checkWin()
        {
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "")
            {
                if (b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b1.Text == b5.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    if (b1.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();

                }
            }
            if (b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "" && b10.Text != "")
            {
                if (b6.Text == b7.Text && b6.Text == b8.Text && b6.Text == b9.Text && b6.Text == b10.Text)
                {
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b8.BackColor = Color.Green;
                    b8.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    b10.BackColor = Color.Green;
                    b10.ForeColor = Color.White;
                    if (b6.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b11.Text != "" && b12.Text != "" && b13.Text != "" && b14.Text != "" && b15.Text != "")
            {
                if (b11.Text == b12.Text && b11.Text == b13.Text && b11.Text == b14.Text && b11.Text == b15.Text)
                {
                    b11.BackColor = Color.Green;
                    b11.ForeColor = Color.White;
                    b12.BackColor = Color.Green;
                    b12.ForeColor = Color.White;
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;
                    b14.BackColor = Color.Green;
                    b14.ForeColor = Color.White;
                    b15.BackColor = Color.Green;
                    b15.ForeColor = Color.White;
                    if (b11.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b16.Text != "" && b17.Text != "" && b18.Text != "" && b19.Text != "" && b20.Text != "")
            {
                if (b16.Text == b17.Text && b16.Text == b18.Text && b16.Text == b19.Text && b16.Text == b20.Text)
                {
                    b16.BackColor = Color.Green;
                    b16.ForeColor = Color.White;
                    b17.BackColor = Color.Green;
                    b17.ForeColor = Color.White;
                    b18.BackColor = Color.Green;
                    b18.ForeColor = Color.White;
                    b19.BackColor = Color.Green;
                    b19.ForeColor = Color.White;
                    b20.BackColor = Color.Green;
                    b20.ForeColor = Color.White;
                    if (b16.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b21.Text != "" && b22.Text != "" && b23.Text != "" && b24.Text != "" && b25.Text != "")
            {
                if (b21.Text == b22.Text && b21.Text == b23.Text && b21.Text == b24.Text && b21.Text == b25.Text)
                {
                    b21.BackColor = Color.Green;
                    b21.ForeColor = Color.White;
                    b22.BackColor = Color.Green;
                    b22.ForeColor = Color.White;
                    b23.BackColor = Color.Green;
                    b23.ForeColor = Color.White;
                    b24.BackColor = Color.Green;
                    b24.ForeColor = Color.White;
                    b25.BackColor = Color.Green;
                    b25.ForeColor = Color.White;
                    if (b21.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b1.Text != "" && b6.Text != "" && b11.Text != "" && b16.Text != "" && b21.Text != "")
            {
                if (b1.Text == b6.Text && b1.Text == b11.Text && b1.Text == b16.Text && b1.Text == b21.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b11.BackColor = Color.Green;
                    b11.ForeColor = Color.White;
                    b16.BackColor = Color.Green;
                    b16.ForeColor = Color.White;
                    b21.BackColor = Color.Green;
                    b21.ForeColor = Color.White;
                    if (b1.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                         player++;
                         playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b2.Text != "" && b7.Text != "" && b12.Text != "" && b17.Text != "" && b22.Text != "")
            {
                if (b2.Text == b7.Text && b2.Text == b12.Text && b2.Text == b17.Text && b2.Text == b22.Text)
                {
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b12.BackColor = Color.Green;
                    b12.ForeColor = Color.White;
                    b17.BackColor = Color.Green;
                    b17.ForeColor = Color.White;
                    b22.BackColor = Color.Green;
                    b22.ForeColor = Color.White;
                    if (b2.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b3.Text != "" && b8.Text != "" && b13.Text != "" && b18.Text != "" && b23.Text != "")
            {
                if (b3.Text == b8.Text && b3.Text == b13.Text && b3.Text == b18.Text && b3.Text == b23.Text)
                {
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b8.BackColor = Color.Green;
                    b8.ForeColor = Color.White;
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;
                    b18.BackColor = Color.Green;
                    b18.ForeColor = Color.White;
                    b23.BackColor = Color.Green;
                    b23.ForeColor = Color.White;

                    if (b3.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                       playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                       cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b4.Text != "" && b9.Text != "" && b14.Text != "" && b19.Text != "" && b24.Text != "")
            {
                if (b4.Text == b9.Text && b4.Text == b14.Text && b4.Text == b19.Text && b4.Text == b24.Text)
                {
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    b14.BackColor = Color.Green;
                    b14.ForeColor = Color.White;
                    b19.BackColor = Color.Green;
                    b19.ForeColor = Color.White;
                    b24.BackColor = Color.Green;
                    b24.ForeColor = Color.White;

                    if (b4.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b5.Text != "" && b10.Text != "" && b15.Text != "" && b20.Text != "" && b25.Text != "")
            {
                if (b5.Text == b10.Text && b5.Text == b15.Text && b5.Text == b20.Text && b5.Text == b25.Text)
                {
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b10.BackColor = Color.Green;
                    b10.ForeColor = Color.White;
                    b15.BackColor = Color.Green;
                    b15.ForeColor = Color.White;
                    b20.BackColor = Color.Green;
                    b20.ForeColor = Color.White;
                    b25.BackColor = Color.Green;
                    b25.ForeColor = Color.White;

                    if (b5.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b1.Text != "" && b7.Text != "" && b13.Text != "" && b19.Text != "" && b25.Text != "")
            {
                if (b1.Text == b7.Text && b1.Text == b13.Text && b1.Text == b19.Text && b1.Text == b25.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;
                    b19.BackColor = Color.Green;
                    b19.ForeColor = Color.White;
                    b25.BackColor = Color.Green;
                    b25.ForeColor = Color.White;

                    if (b1.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b5.Text != "" && b9.Text != "" && b13.Text != "" && b17.Text != "" && b21.Text != "")
            {
                if (b5.Text == b9.Text && b5.Text == b13.Text && b5.Text == b17.Text && b5.Text == b21.Text)
                {
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;
                    b17.BackColor = Color.Green;
                    b17.ForeColor = Color.White;
                    b21.BackColor = Color.Green;
                    b21.ForeColor = Color.White;

                    if (b5.Text == "X")
                    {
                        MessageBox.Show("You Win!");
                        player++;
                        playerScore.Text = "Player       = " + player;
                    }
                    else
                    {
                        MessageBox.Show("Computer Wins!");
                        cp++;
                        cpScore.Text = "Computer = " + cp;
                    }
                    clearGame();
                }
            }
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" &&
                b4.Text != "" && b5.Text != "" && b6.Text != "" &&
                b7.Text != "" && b8.Text != "" && b9.Text != "" &&
                b10.Text != "" && b11.Text != "" && b12.Text != "" &&
                b13.Text != "" && b14.Text != "" && b15.Text != "" &&
                b16.Text != "" && b17.Text != "" && b18.Text != "" &&
                b19.Text != "" && b20.Text != "" && b21.Text != "" &&
                b22.Text != "" && b23.Text != "" && b24.Text != "" &&
                b25.Text != "")
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
            noTurn = 0;

            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            b10.Text = "";
            b11.Text = "";
            b12.Text = "";
            b13.Text = "";
            b14.Text = "";
            b15.Text = "";
            b16.Text = "";
            b17.Text = "";
            b18.Text = "";
            b19.Text = "";
            b20.Text = "";
            b21.Text = "";
            b22.Text = "";
            b23.Text = "";
            b24.Text = "";
            b25.Text = "";

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
            b10.BackColor = Color.Empty;
            b10.ForeColor = Color.Black;
            b10.UseVisualStyleBackColor = true;
            b11.BackColor = Color.Empty;
            b11.ForeColor = Color.Black;
            b11.UseVisualStyleBackColor = true;
            b12.BackColor = Color.Empty;
            b12.ForeColor = Color.Black;
            b12.UseVisualStyleBackColor = true;
            b13.BackColor = Color.Empty;
            b13.ForeColor = Color.Black;
            b13.UseVisualStyleBackColor = true;
            b14.BackColor = Color.Empty;
            b14.ForeColor = Color.Black;
            b14.UseVisualStyleBackColor = true;
            b15.BackColor = Color.Empty;
            b15.ForeColor = Color.Black;
            b15.UseVisualStyleBackColor = true;
            b16.BackColor = Color.Empty;
            b16.ForeColor = Color.Black;
            b16.UseVisualStyleBackColor = true;
            b17.BackColor = Color.Empty;
            b17.ForeColor = Color.Black;
            b17.UseVisualStyleBackColor = true;
            b18.BackColor = Color.Empty;
            b18.ForeColor = Color.Black;
            b18.UseVisualStyleBackColor = true;
            b19.BackColor = Color.Empty;
            b19.ForeColor = Color.Black;
            b19.UseVisualStyleBackColor = true;
            b20.BackColor = Color.Empty;
            b20.ForeColor = Color.Black;
            b20.UseVisualStyleBackColor = true;
            b21.BackColor = Color.Empty;
            b21.ForeColor = Color.Black;
            b21.UseVisualStyleBackColor = true;
            b22.BackColor = Color.Empty;
            b22.ForeColor = Color.Black;
            b22.UseVisualStyleBackColor = true;
            b23.BackColor = Color.Empty;
            b23.ForeColor = Color.Black;
            b23.UseVisualStyleBackColor = true;
            b24.BackColor = Color.Empty;
            b24.ForeColor = Color.Black;
            b24.UseVisualStyleBackColor = true;
            b25.BackColor = Color.Empty;
            b25.ForeColor = Color.Black;
            b25.UseVisualStyleBackColor = true;

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            b10.Enabled = true;
            b11.Enabled = true;
            b12.Enabled = true;
            b13.Enabled = true;
            b14.Enabled = true;
            b15.Enabled = true;
            b16.Enabled = true;
            b17.Enabled = true;
            b18.Enabled = true;
            b19.Enabled = true;
            b20.Enabled = true;
            b21.Enabled = true;
            b22.Enabled = true;
            b23.Enabled = true;
            b24.Enabled = true;
            b25.Enabled = true;
        }
        //AI Section
        /* 
         * AI Logic: 
         * First move to check if he can win
         * Second move if he can lose (to prevent it)
         * If center is not taken player two can be put in a situation that
         * player one has two wining oves so third move is to check for center.
         * Else take corner
         */
        private void aiMove()
        {
            if (turn != 1)
            {
                if (checkAIWin() == false)
                {
                    if (checkAILose() == false)
                    {
                        if (checkAICenter() == false)
                        {
                            if (checkAICorner() == false)
                                choseRemaining();
                        }
                    }
                }
            }
        }
        private bool checkAIWin()
        {
            //section 1.1
            if (b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b5.Text == "")
            {
                if (b1.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b5.Text && b4.Text == "")
            {
                if (b1.Text == "O")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b2.Text && b1.Text == b5.Text && b1.Text == b4.Text && b3.Text == "")
            {
                if (b1.Text == "O")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b5.Text && b1.Text == b3.Text && b1.Text == b4.Text && b2.Text == "")
            {
                if (b1.Text == "O")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b2.Text && b5.Text == b3.Text && b5.Text == b4.Text && b1.Text == "")
            {
                if (b5.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.1
            if (b6.Text == b7.Text && b6.Text == b8.Text && b6.Text == b9.Text && b10.Text == "")
            {
                if (b6.Text == "O")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b7.Text && b6.Text == b8.Text && b6.Text == b10.Text && b9.Text == "")
            {
                if (b6.Text == "O")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b7.Text && b6.Text == b10.Text && b6.Text == b9.Text && b8.Text == "")
            {
                if (b6.Text == "O")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b10.Text && b6.Text == b8.Text && b6.Text == b9.Text && b7.Text == "")
            {
                if (b6.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b10.Text == b7.Text && b10.Text == b8.Text && b10.Text == b9.Text && b6.Text == "")
            {
                if (b10.Text == "O")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            //section 3.1
            if (b11.Text == b12.Text && b11.Text == b13.Text && b11.Text == b14.Text && b15.Text == "")
            {
                if (b11.Text == "O")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b11.Text == b12.Text && b11.Text == b13.Text && b11.Text == b15.Text && b14.Text == "")
            {
                if (b11.Text == "O")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b11.Text == b12.Text && b11.Text == b15.Text && b11.Text == b14.Text && b13.Text == "")
            {
                if (b11.Text == "O")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b11.Text == b15.Text && b11.Text == b13.Text && b11.Text == b14.Text && b12.Text == "")
            {
                if (b11.Text == "O")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b15.Text == b12.Text && b15.Text == b13.Text && b15.Text == b14.Text && b11.Text == "")
            {
                if (b15.Text == "O")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            //section 4.1
            if (b16.Text == b17.Text && b16.Text == b18.Text && b16.Text == b19.Text && b20.Text == "")
            {
                if (b16.Text == "O")
                {
                    b20.PerformClick();
                    return true;
                }
            }
            if (b16.Text == b17.Text && b16.Text == b18.Text && b16.Text == b20.Text && b19.Text == "")
            {
                if (b16.Text == "O")
                {
                    b19.PerformClick();
                    return true;
                }
            }
            if (b16.Text == b17.Text && b16.Text == b20.Text && b16.Text == b19.Text && b18.Text == "")
            {
                if (b16.Text == "O")
                {
                    b18.PerformClick();
                    return true;
                }
            }
            if (b16.Text == b20.Text && b16.Text == b18.Text && b16.Text == b19.Text && b17.Text == "")
            {
                if (b16.Text == "O")
                {
                    b17.PerformClick();
                    return true;
                }
            }
            if (b20.Text == b17.Text && b20.Text == b18.Text && b20.Text == b19.Text && b16.Text == "")
            {
                if (b20.Text == "O")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            //section 5.1
            if (b21.Text == b22.Text && b21.Text == b23.Text && b21.Text == b24.Text && b25.Text == "")
            {
                if (b21.Text == "O")
                {
                    b25.PerformClick();
                    return true;
                }
            }
            if (b21.Text == b22.Text && b21.Text == b23.Text && b21.Text == b25.Text && b24.Text == "")
            {
                if (b21.Text == "O")
                {
                    b24.PerformClick();
                    return true;
                }
            }
                if (b21.Text == b22.Text && b21.Text == b25.Text && b21.Text == b24.Text && b23.Text == "")
                {
                    if (b21.Text == "O")
                    {
                        b23.PerformClick();
                        return true;
                    }
                }
                if (b21.Text == b25.Text && b21.Text == b23.Text && b21.Text == b24.Text && b22.Text == "")
                {
                    if (b21.Text == "O")
                    {
                        b22.PerformClick();
                        return true;
                    }
                }
                if (b25.Text == b22.Text && b25.Text == b23.Text && b25.Text == b24.Text && b21.Text == "")
                {
                    if (b25.Text == "O")
                    {
                        b21.PerformClick();
                        return true;
                    }
                }
            //section 1.2
           if (b1.Text == b6.Text && b1.Text == b11.Text && b1.Text == b16.Text && b21.Text == "")
            {
                if (b1.Text == "O")
                {
                    b21.PerformClick();
                    return true;
                }
            }
           if (b1.Text == b6.Text && b1.Text == b11.Text && b1.Text == b21.Text && b16.Text == "")
           {
               if (b1.Text == "O")
               {
                   b16.PerformClick();
                   return true;
               }
           }
           if (b1.Text == b6.Text && b1.Text == b21.Text && b1.Text == b16.Text && b11.Text == "")
           {
               if (b1.Text == "O")
               {
                   b11.PerformClick();
                   return true;
               }
           }
           if (b1.Text == b21.Text && b1.Text == b11.Text && b1.Text == b16.Text && b6.Text == "")
           {
               if (b1.Text == "O")
               {
                   b6.PerformClick();
                   return true;
               }
           }
           if (b21.Text == b6.Text && b21.Text == b11.Text && b21.Text == b16.Text && b1.Text == "")
           {
               if (b21.Text == "O")
               {
                   b1.PerformClick();
                   return true;
               }
           }
            //section 2.2
           if (b2.Text == b7.Text && b2.Text == b12.Text && b2.Text == b17.Text && b22.Text == "")
           {
               if (b2.Text == "O")
               {
                   b22.PerformClick();
                   return true;
               }
           }
           if (b2.Text == b7.Text && b2.Text == b12.Text && b2.Text == b22.Text && b17.Text == "")
           {
               if (b2.Text == "O")
               {
                   b17.PerformClick();
                   return true;
               }
           }
           if (b2.Text == b7.Text && b2.Text == b22.Text && b2.Text == b17.Text && b12.Text == "")
           {
               if (b2.Text == "O")
               {
                   b12.PerformClick();
                   return true;
               }
           }
           if (b2.Text == b22.Text && b2.Text == b12.Text && b2.Text == b17.Text && b7.Text == "")
           {
               if (b2.Text == "O")
               {
                   b7.PerformClick();
                   return true;
               }
           }
           if (b22.Text == b7.Text && b22.Text == b12.Text && b22.Text == b17.Text && b2.Text == "")
           {
               if (b22.Text == "O")
               {
                   b2.PerformClick();
                   return true;
               }
           }
            //section 3.2
           if (b3.Text == b8.Text && b3.Text == b13.Text && b3.Text == b18.Text && b23.Text == "")
           {
               if (b3.Text == "O")
               {
                   b23.PerformClick();
                   return true;
               }
           }
           if (b3.Text == b8.Text && b3.Text == b13.Text && b3.Text == b23.Text && b18.Text == "")
           {
               if (b3.Text == "O")
               {
                   b18.PerformClick();
                   return true;
               }
           }
           if (b3.Text == b8.Text && b3.Text == b23.Text && b3.Text == b18.Text && b13.Text == "")
           {
               if (b3.Text == "O")
               {
                   b13.PerformClick();
                   return true;
               }
           }
           if (b3.Text == b23.Text && b3.Text == b13.Text && b3.Text == b18.Text && b8.Text == "")
           {
               if (b3.Text == "O")
               {
                   b8.PerformClick();
                   return true;
               }
           }
           if (b23.Text == b8.Text && b23.Text == b13.Text && b23.Text == b18.Text && b3.Text == "")
           {
               if (b23.Text == "O")
               {
                   b3.PerformClick();
                   return true;
               }
           }
            //section 4.2
           if (b4.Text == b9.Text && b4.Text == b14.Text && b4.Text == b19.Text && b24.Text == "")
           {
               if (b4.Text == "O")
               {
                   b24.PerformClick();
                   return true;
               }
           }
           if (b4.Text == b9.Text && b4.Text == b14.Text && b4.Text == b24.Text && b19.Text == "")
           {
               if (b4.Text == "O")
               {
                   b19.PerformClick();
                   return true;
               }
           }
           if (b4.Text == b9.Text && b4.Text == b24.Text && b4.Text == b19.Text && b14.Text == "")
           {
               if (b4.Text == "O")
               {
                   b14.PerformClick();
                   return true;
               }
           }
           if (b4.Text == b24.Text && b4.Text == b14.Text && b4.Text == b19.Text && b9.Text == "")
           {
               if (b4.Text == "O")
               {
                   b9.PerformClick();
                   return true;
               }
           }
           if (b24.Text == b9.Text && b24.Text == b14.Text && b24.Text == b19.Text && b4.Text == "")
           {
               if (b24.Text == "O")
               {
                   b4.PerformClick();
                   return true;
               }
           }
            //section 5.2
           if (b5.Text == b10.Text && b5.Text == b15.Text && b5.Text == b20.Text && b25.Text == "")
           {
               if (b5.Text == "O")
               {
                   b25.PerformClick();
                   return true;
               }
           }
           if (b5.Text == b10.Text && b5.Text == b15.Text && b5.Text == b25.Text && b20.Text == "")
           {
               if (b5.Text == "O")
               {
                   b20.PerformClick();
                   return true;
               }
           }
           if (b5.Text == b10.Text && b5.Text == b25.Text && b5.Text == b20.Text && b15.Text == "")
           {
               if (b5.Text == "O")
               {
                   b15.PerformClick();
                   return true;
               }
           }
           if (b5.Text == b25.Text && b5.Text == b15.Text && b5.Text == b20.Text && b10.Text == "")
           {
               if (b5.Text == "O")
               {
                   b10.PerformClick();
                   return true;
               }
           }
           if (b25.Text == b10.Text && b25.Text == b15.Text && b25.Text == b20.Text && b5.Text == "")
           {
               if (b25.Text == "O")
               {
                   b5.PerformClick();
                   return true;
               }
           }
            //section 1.2.3
           if (b1.Text == b7.Text && b1.Text == b13.Text && b1.Text == b19.Text && b25.Text == "")
           {
               if (b1.Text == "O")
               {
                   b25.PerformClick();
                   return true;
               }
           }
           if (b1.Text == b7.Text && b1.Text == b13.Text && b1.Text == b25.Text && b19.Text == "")
           {
               if (b1.Text == "O")
               {
                   b19.PerformClick();
                   return true;
               }
           }
           if (b1.Text == b7.Text && b1.Text == b25.Text && b1.Text == b19.Text && b13.Text == "")
           {
               if (b1.Text == "O")
               {
                   b13.PerformClick();
                   return true;
               }
           }
           if (b1.Text == b25.Text && b1.Text == b13.Text && b1.Text == b19.Text && b7.Text == "")
           {
               if (b1.Text == "O")
               {
                   b7.PerformClick();
                   return true;
               }
           }
           if (b25.Text == b7.Text && b25.Text == b13.Text && b25.Text == b19.Text && b1.Text == "")
           {
               if (b25.Text == "O")
               {
                   b1.PerformClick();
                   return true;
               }
           }
            //section 3.2.1
           if (b5.Text == b9.Text && b5.Text == b13.Text && b5.Text == b17.Text && b21.Text == "")
           {
               if (b5.Text == "O")
               {
                   b21.PerformClick();
                   return true;
               }
           }
           if (b5.Text == b9.Text && b5.Text == b13.Text && b5.Text == b21.Text && b17.Text == "")
           {
               if (b5.Text == "O")
               {
                   b17.PerformClick();
                   return true;
               }
           }
           if (b5.Text == b9.Text && b5.Text == b21.Text && b5.Text == b17.Text && b13.Text == "")
           {
               if (b5.Text == "O")
               {
                   b13.PerformClick();
                   return true;
               }
           }
           if (b5.Text == b21.Text && b5.Text == b13.Text && b5.Text == b17.Text && b9.Text == "")
           {
               if (b5.Text == "O")
               {
                   b9.PerformClick();
                   return true;
               }
           }
           if (b21.Text == b9.Text && b21.Text == b13.Text && b21.Text == b17.Text && b5.Text == "")
           {
               if (b21.Text == "O")
               {
                   b5.PerformClick();
                   return true;
               }
           }
                return false;

        } //done v1
        private bool checkAILose()
        {
            //section 1.1
            if (b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text && b5.Text == "")
            {
                if (b1.Text == "X")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b5.Text && b4.Text == "")
            {
                if (b1.Text == "X")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b2.Text && b1.Text == b5.Text && b1.Text == b4.Text && b3.Text == "")
            {
                if (b1.Text == "X")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b5.Text && b1.Text == b3.Text && b1.Text == b4.Text && b2.Text == "")
            {
                if (b1.Text == "X")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b2.Text && b5.Text == b3.Text && b5.Text == b4.Text && b1.Text == "")
            {
                if (b5.Text == "X")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.1
            if (b6.Text == b7.Text && b6.Text == b8.Text && b6.Text == b9.Text && b10.Text == "")
            {
                if (b6.Text == "X")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b7.Text && b6.Text == b8.Text && b6.Text == b10.Text && b9.Text == "")
            {
                if (b6.Text == "X")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b7.Text && b6.Text == b10.Text && b6.Text == b9.Text && b8.Text == "")
            {
                if (b6.Text == "X")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b10.Text && b6.Text == b8.Text && b6.Text == b9.Text && b7.Text == "")
            {
                if (b6.Text == "X")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b10.Text == b7.Text && b10.Text == b8.Text && b10.Text == b9.Text && b6.Text == "")
            {
                if (b10.Text == "X")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            //section 3.1
            if (b11.Text == b12.Text && b11.Text == b13.Text && b11.Text == b14.Text && b15.Text == "")
            {
                if (b11.Text == "X")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b11.Text == b12.Text && b11.Text == b13.Text && b11.Text == b15.Text && b14.Text == "")
            {
                if (b11.Text == "X")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b11.Text == b12.Text && b11.Text == b15.Text && b11.Text == b14.Text && b13.Text == "")
            {
                if (b11.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b11.Text == b15.Text && b11.Text == b13.Text && b11.Text == b14.Text && b12.Text == "")
            {
                if (b11.Text == "X")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b15.Text == b12.Text && b15.Text == b13.Text && b15.Text == b14.Text && b11.Text == "")
            {
                if (b15.Text == "X")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            //section 4.1
            if (b16.Text == b17.Text && b16.Text == b18.Text && b16.Text == b19.Text && b20.Text == "")
            {
                if (b16.Text == "X")
                {
                    b20.PerformClick();
                    return true;
                }
            }
            if (b16.Text == b17.Text && b16.Text == b18.Text && b16.Text == b20.Text && b19.Text == "")
            {
                if (b16.Text == "X")
                {
                    b19.PerformClick();
                    return true;
                }
            }
            if (b16.Text == b17.Text && b16.Text == b20.Text && b16.Text == b19.Text && b18.Text == "")
            {
                if (b16.Text == "X")
                {
                    b18.PerformClick();
                    return true;
                }
            }
            if (b16.Text == b20.Text && b16.Text == b18.Text && b16.Text == b19.Text && b17.Text == "")
            {
                if (b16.Text == "X")
                {
                    b17.PerformClick();
                    return true;
                }
            }
            if (b20.Text == b17.Text && b20.Text == b18.Text && b20.Text == b19.Text && b16.Text == "")
            {
                if (b20.Text == "X")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            //section 5.1
            if (b21.Text == b22.Text && b21.Text == b23.Text && b21.Text == b24.Text && b25.Text == "")
            {
                if (b21.Text == "X")
                {
                    b25.PerformClick();
                    return true;
                }
            }
            if (b21.Text == b22.Text && b21.Text == b23.Text && b21.Text == b25.Text && b24.Text == "")
            {
                if (b21.Text == "X")
                {
                    b24.PerformClick();
                    return true;
                }
            }
            if (b21.Text == b22.Text && b21.Text == b25.Text && b21.Text == b24.Text && b23.Text == "")
            {
                if (b21.Text == "X")
                {
                    b23.PerformClick();
                    return true;
                }
            }
            if (b21.Text == b25.Text && b21.Text == b23.Text && b21.Text == b24.Text && b22.Text == "")
            {
                if (b21.Text == "X")
                {
                    b22.PerformClick();
                    return true;
                }
            }
            if (b25.Text == b22.Text && b25.Text == b23.Text && b25.Text == b24.Text && b21.Text == "")
            {
                if (b25.Text == "X")
                {
                    b21.PerformClick();
                    return true;
                }
            }
            //section 1.2
            if (b1.Text == b6.Text && b1.Text == b11.Text && b1.Text == b16.Text && b21.Text == "")
            {
                if (b1.Text == "X")
                {
                    b21.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b6.Text && b1.Text == b11.Text && b1.Text == b21.Text && b16.Text == "")
            {
                if (b1.Text == "X")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b6.Text && b1.Text == b21.Text && b1.Text == b16.Text && b11.Text == "")
            {
                if (b1.Text == "X")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b21.Text && b1.Text == b11.Text && b1.Text == b16.Text && b6.Text == "")
            {
                if (b1.Text == "X")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b21.Text == b6.Text && b21.Text == b11.Text && b21.Text == b16.Text && b1.Text == "")
            {
                if (b21.Text == "X")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.2
            if (b2.Text == b7.Text && b2.Text == b12.Text && b2.Text == b17.Text && b22.Text == "")
            {
                if (b2.Text == "X")
                {
                    b22.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b7.Text && b2.Text == b12.Text && b2.Text == b22.Text && b17.Text == "")
            {
                if (b2.Text == "X")
                {
                    b17.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b7.Text && b2.Text == b22.Text && b2.Text == b17.Text && b12.Text == "")
            {
                if (b2.Text == "X")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b22.Text && b2.Text == b12.Text && b2.Text == b17.Text && b7.Text == "")
            {
                if (b2.Text == "X")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b22.Text == b7.Text && b22.Text == b12.Text && b22.Text == b17.Text && b2.Text == "")
            {
                if (b22.Text == "X")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            //section 3.2
            if (b3.Text == b8.Text && b3.Text == b13.Text && b3.Text == b18.Text && b23.Text == "")
            {
                if (b3.Text == "X")
                {
                    b23.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b8.Text && b3.Text == b13.Text && b3.Text == b23.Text && b18.Text == "")
            {
                if (b3.Text == "X")
                {
                    b18.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b8.Text && b3.Text == b23.Text && b3.Text == b18.Text && b13.Text == "")
            {
                if (b3.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b23.Text && b3.Text == b13.Text && b3.Text == b18.Text && b8.Text == "")
            {
                if (b3.Text == "X")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b23.Text == b8.Text && b23.Text == b13.Text && b23.Text == b18.Text && b3.Text == "")
            {
                if (b23.Text == "X")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            //section 4.2
            if (b4.Text == b9.Text && b4.Text == b14.Text && b4.Text == b19.Text && b24.Text == "")
            {
                if (b4.Text == "X")
                {
                    b24.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b9.Text && b4.Text == b14.Text && b4.Text == b24.Text && b19.Text == "")
            {
                if (b4.Text == "X")
                {
                    b19.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b9.Text && b4.Text == b24.Text && b4.Text == b19.Text && b14.Text == "")
            {
                if (b4.Text == "X")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b24.Text && b4.Text == b14.Text && b4.Text == b19.Text && b9.Text == "")
            {
                if (b4.Text == "X")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b24.Text == b9.Text && b24.Text == b14.Text && b24.Text == b19.Text && b4.Text == "")
            {
                if (b24.Text == "X")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            //section 5.2
            if (b5.Text == b10.Text && b5.Text == b15.Text && b5.Text == b20.Text && b25.Text == "")
            {
                if (b5.Text == "X")
                {
                    b25.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b10.Text && b5.Text == b15.Text && b5.Text == b25.Text && b20.Text == "")
            {
                if (b5.Text == "X")
                {
                    b20.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b10.Text && b5.Text == b25.Text && b5.Text == b20.Text && b15.Text == "")
            {
                if (b5.Text == "X")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b25.Text && b5.Text == b15.Text && b5.Text == b20.Text && b10.Text == "")
            {
                if (b5.Text == "X")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b25.Text == b10.Text && b25.Text == b15.Text && b25.Text == b20.Text && b5.Text == "")
            {
                if (b25.Text == "X")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            //section 1.2.3
            if (b1.Text == b7.Text && b1.Text == b13.Text && b1.Text == b19.Text && b25.Text == "")
            {
                if (b1.Text == "X")
                {
                    b25.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b7.Text && b1.Text == b13.Text && b1.Text == b25.Text && b19.Text == "")
            {
                if (b1.Text == "X")
                {
                    b19.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b7.Text && b1.Text == b25.Text && b1.Text == b19.Text && b13.Text == "")
            {
                if (b1.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b25.Text && b1.Text == b13.Text && b1.Text == b19.Text && b7.Text == "")
            {
                if (b1.Text == "X")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b25.Text == b7.Text && b25.Text == b13.Text && b25.Text == b19.Text && b1.Text == "")
            {
                if (b25.Text == "X")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 3.2.1
            if (b5.Text == b9.Text && b5.Text == b13.Text && b5.Text == b17.Text && b21.Text == "")
            {
                if (b5.Text == "X")
                {
                    b21.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b9.Text && b5.Text == b13.Text && b5.Text == b21.Text && b17.Text == "")
            {
                if (b5.Text == "X")
                {
                    b17.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b9.Text && b5.Text == b21.Text && b5.Text == b17.Text && b13.Text == "")
            {
                if (b5.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b21.Text && b5.Text == b13.Text && b5.Text == b17.Text && b9.Text == "")
            {
                if (b5.Text == "X")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b21.Text == b9.Text && b21.Text == b13.Text && b21.Text == b17.Text && b5.Text == "")
            {
                if (b21.Text == "X")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            return false;

        }// done v1
        private bool checkAICenter()
        {
            if (b13.Text == "")
            {
                b13.PerformClick();
                return true;
            }
            else
                return false;
        } // done v1
        private bool checkAICorner()
        {
            //fork
            if (b13.Text == "X" && b8.Text == "X" && b3.Text == "X" && b17.Text == "X" && b16.Text == "X" && b19.Text == "X" && b18.Text == "")
            {
                b18.PerformClick();
                return true;
            }
            if (b13.Text == "X" && b8.Text == "X" && b3.Text == "X" && b22.Text == "X" && b21.Text == "X" && b25.Text == "X" && b23.Text == "")
            {
                b23.PerformClick();
                return true;
            }
            if (b13.Text == "X" && b8.Text == "X" && b3.Text == "X" && b17.Text == "X" && b21.Text == "X" && b19.Text == "X" && b25.Text == "X" && (b24.Text == "X" || b22.Text == "X") && b23.Text == "")
            {
                b23.PerformClick();
                return true;
            }
            if (b13.Text == "X" && b12.Text == "X" && b11.Text == "X" && (b10.Text == "X" || b20.Text == "X") && b5.Text == "X" && b25.Text == "X" && b15.Text == "")
            {
                b15.PerformClick();
                return true;
            }
            if (b19.Text == "X" && b18.Text == "X" && b17.Text == "X" && (b10.Text == "X" || b15.Text == "X") && b25.Text == "X" && b5.Text == "X" && b20.Text == "")
            {
                b20.PerformClick();
                return true;
            }
            if (b1.Text == "X" && b6.Text == "X" && b11.Text == "X" && b23.Text == "X" && b23.Text == "X" && b25.Text == "X" && b21.Text == "")
            {
                b21.PerformClick();
                return true;
            }
            if (b2.Text == "X" && b7.Text == "X" && b17.Text == "X" && b21.Text == "X" && b24.Text == "X" && b25.Text == "X" && b22.Text == "")
            {
                b22.PerformClick();
                return true;
            }
            if (b4.Text == "X" && b9.Text == "X" && b19.Text == "X" && b21.Text == "X" && b22.Text == "X" && b25.Text == "X" && b24.Text == "")
            {
                b24.PerformClick();
                return true;
            }
            if (b5.Text == "X" && b10.Text == "X" && b25.Text == "X" && b19.Text == "X" && b17.Text == "X" && b16.Text == "X" && b20.Text == "")
            {
                b20.PerformClick();
                return true;
            }
            if (b5.Text == "X" && b25.Text == "X" && (b20.Text == "X" || b15.Text == "X") && b9.Text == "X" && b7.Text == "X" && b6.Text == "X" && b10.Text == "")
            {
                b10.PerformClick();
                return true;
            }
                if (b1.Text == "")
                {
                    b1.PerformClick();
                    return true;
                }
                if (b25.Text == "")
                {
                    b25.PerformClick();
                    return true;
                }
                if (b7.Text == "")
                {
                    b7.PerformClick();
                    return true;
                }
                if (b19.Text == "")
                {
                    b19.PerformClick();
                    return true;
                }
            
            //chose another path if 5 in a row in blocked
            
                if (b9.Text == "")
                {
                    b9.PerformClick();
                    return true;
                }
                if (b17.Text == "")
                {
                    b17.PerformClick();
                    return true;
                }
                if (b5.Text == "")
                {
                    b5.PerformClick();
                    return true;
                }
                if (b21.Text == "")
                {
                    b21.PerformClick();
                    return true;
                }
    
            return false;
        } // done v1
        private bool choseRemaining()
        {
            if (b13.Text == "X" && b8.Text == "X" && b18.Text == "X" && (noTurn == 5 || noTurn == 6))
            {
                if (b19.Text == "")
                {
                    b19.PerformClick();
                    return true;
                }
                if(b16.Text == "")
                {
                    b16.PerformClick();
                        return true;
                }
                if(b3.Text == "")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            //chose another path if 5 in a row in blocked
            if (b1.Text != "X" && b6.Text != "X" && b11.Text != "X" && b16.Text != "X" && b21.Text != "X")
            {
                if (b1.Text == "")
                {
                    b1.PerformClick();
                    return true;
                }
                if (b6.Text == "")
                {
                    b6.PerformClick();
                    return true;
                }
                if (b11.Text == "")
                {
                    b11.PerformClick();
                    return true;
                }
                if (b16.Text == "")
                {
                    b16.PerformClick();
                    return true;
                }
                if (b21.Text == "")
                {
                    b21.PerformClick();
                    return true;
                }
            }
            //chose another path if 5 in a row in blocked
            if (b2.Text != "X" && b7.Text != "X" && b12.Text != "X" && b17.Text != "X" && b22.Text != "X")
            {
                if (b2.Text == "")
                {
                    b2.PerformClick();
                    return true;
                }
                if (b7.Text == "")
                {
                    b7.PerformClick();
                    return true;
                }
                if (b12.Text == "")
                {
                    b12.PerformClick();
                    return true;
                }
                if (b17.Text == "")
                {
                    b17.PerformClick();
                    return true;
                }
                if (b22.Text == "")
                {
                    b22.PerformClick();
                    return true;
                }
            }
            //chose another path if 5 in a row in blocked
            if (b3.Text != "X" && b8.Text != "X" && b13.Text != "X" && b18.Text != "X" && b23.Text != "X")
            {
                if (b3.Text == "")
                {
                    b3.PerformClick();
                    return true;
                }
                if (b8.Text == "")
                {
                    b8.PerformClick();
                    return true;
                }
                if (b18.Text == "")
                {
                    b18.PerformClick();
                    return true;
                }
                if (b23.Text == "")
                {
                    b23.PerformClick();
                    return true;
                }
            }
            //chose another path if 5 in a row in blocked
            if (b4.Text != "X" && b9.Text != "X" && b14.Text != "X" && b19.Text != "X" && b24.Text != "X")
            {
                if (b4.Text == "")
                {
                    b4.PerformClick();
                    return true;
                }
                if (b9.Text == "")
                {
                    b9.PerformClick();
                    return true;
                }
                if (b14.Text == "")
                {
                    b14.PerformClick();
                    return true;
                }
                if (b19.Text == "")
                {
                    b19.PerformClick();
                    return true;
                }
                if (b24.Text == "")
                {
                    b24.PerformClick();
                    return true;
                }
            }
            if (b5.Text != "X" && b10.Text != "X" && b15.Text != "X" && b20.Text != "X" && b25.Text != "X")
            {
                if (b5.Text == "")
                {
                    b5.PerformClick();
                    return true;
                }
                if (b10.Text == "")
                {
                    b10.PerformClick();
                    return true;
                }
                if (b15.Text == "")
                {
                    b15.PerformClick();
                    return true;
                }
                if (b20.Text == "")
                {
                    b20.PerformClick();
                    return true;
                }
                if (b25.Text == "")
                {
                    b25.PerformClick();
                    return true;
                }
            }
            //horizantal combinations
            if (b1.Text != "X" && b2.Text != "X" && b3.Text != "X" && b4.Text != "X" && b5.Text != "X")
            {
                if (b1.Text == "")
                {
                    b1.PerformClick();
                    return true;
                }
                if (b2.Text == "")
                {
                    b2.PerformClick();
                    return true;
                }
                if (b3.Text == "")
                {
                    b3.PerformClick();
                    return true;
                }
                if (b4.Text == "")
                {
                    b4.PerformClick();
                    return true;
                }
                if (b5.Text == "")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b6.Text != "X" && b7.Text != "X" && b8.Text != "X" && b9.Text != "X" && b10.Text != "X")
            {
                if (b6.Text == "")
                {
                    b6.PerformClick();
                    return true;
                }
                if (b8.Text == "")
                {
                    b8.PerformClick();
                    return true;
                }
                if (b9.Text == "")
                {
                    b9.PerformClick();
                    return true;
                }
                if (b10.Text == "")
                {
                    b10.PerformClick();
                    return true;
                }
                if (b7.Text == "")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b11.Text != "X" && b12.Text != "X" && b13.Text != "X" && b14.Text != "X" && b15.Text != "X")
            {
                if (b11.Text == "")
                {
                    b11.PerformClick();
                    return true;
                }
                if (b12.Text == "")
                {
                    b12.PerformClick();
                    return true;
                }
                if (b13.Text == "")
                {
                    b13.PerformClick();
                    return true;
                }
                if (b14.Text == "")
                {
                    b14.PerformClick();
                    return true;
                }
                if (b15.Text == "")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b16.Text != "X" && b17.Text != "X" && b18.Text != "X" && b19.Text != "X" && b20.Text != "X")
            {
                if (b16.Text == "")
                {
                    b16.PerformClick();
                    return true;
                }
                if (b17.Text == "")
                {
                    b17.PerformClick();
                    return true;
                }
                if (b18.Text == "")
                {
                    b18.PerformClick();
                    return true;
                }
                if (b19.Text == "")
                {
                    b19.PerformClick();
                    return true;
                }
                if (b20.Text == "")
                {
                    b20.PerformClick();
                    return true;
                }
            }
            if (b21.Text != "X" && b22.Text != "X" && b23.Text != "X" && b24.Text != "X" && b25.Text != "X")
            {
                if (b21.Text == "")
                {
                    b21.PerformClick();
                    return true;
                }
                if (b22.Text == "")
                {
                    b22.PerformClick();
                    return true;
                }
                if (b23.Text == "")
                {
                    b23.PerformClick();
                    return true;
                }
                if (b24.Text == "")
                {
                    b24.PerformClick();
                    return true;
                }
                if (b25.Text == "")
                {
                    b25.PerformClick();
                    return true;
                }
            }
            //just fill up the rest (draw result)
            if (b2.Text == "")
            {
                b2.PerformClick();
                return true;
            }
            if (b3.Text == "")
            {
                b3.PerformClick();
                return true;
            }
            if (b4.Text == "")
            {
                b4.PerformClick();
                return true;
            }
            if (b6.Text == "")
            {
                b6.PerformClick();
                return true;
            }
            if (b8.Text == "")
            {
                b8.PerformClick();
                return true;
            }
            if (b10.Text == "")
            {
                b10.PerformClick();
                return true;
            }
            if (b11.Text == "")
            {
                b11.PerformClick();
                return true;
            }
            if (b12.Text == "")
            {
                b12.PerformClick();
                return true;
            }
            if (b14.Text == "")
            {
                b14.PerformClick();
                return true;
            }
            if (b15.Text == "")
            {
                b15.PerformClick();
                return true;
            }
            if (b16.Text == "")
            {
                b16.PerformClick();
                return true;
            }
            if (b18.Text == "")
            {
                b18.PerformClick();
                return true;
            }
            if (b20.Text == "")
            {
                b20.PerformClick();
                return true;
            }
            if (b22.Text == "")
            {
                b22.PerformClick();
                return true;
            }
            if (b23.Text == "")
            {
                b23.PerformClick();
                return true;
            }
            if (b24.Text == "")
            {
                b24.PerformClick();
                return true;
            }
            return false;
        } // done v1

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearGame();
            player = 0;
            cp = 0;
            playerScore.Text = "Player       = " + player;
            cpScore.Text = "Computer = " + cp;
        }  

    }
}
