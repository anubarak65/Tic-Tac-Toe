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
    public partial class Grid4 : Form
    {
        public Grid4()
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
        
        //a method to check if the game has ended 
        private void checkWin()
        {
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "")
            {
                if (b1.Text == b2.Text && b1.Text == b3.Text && b1.Text == b4.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
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
            if (b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "")
            {
                if (b5.Text == b6.Text && b5.Text == b7.Text && b5.Text == b8.Text)
                {
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b8.BackColor = Color.Green;
                    b8.ForeColor = Color.White;
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
            if (b9.Text != "" && b10.Text != "" && b11.Text != "" && b12.Text != "" )
            {
                if (b9.Text == b10.Text && b9.Text == b11.Text && b9.Text == b12.Text)
                {
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    b10.BackColor = Color.Green;
                    b10.ForeColor = Color.White;
                    b11.BackColor = Color.Green;
                    b11.ForeColor = Color.White;
                    b12.BackColor = Color.Green;
                    b12.ForeColor = Color.White;
                    if (b9.Text == "X")
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
            if (b13.Text != "" && b14.Text != "" && b15.Text != "" && b16.Text != "")
            {
                if (b13.Text == b14.Text && b13.Text == b15.Text && b13.Text == b16.Text)
                {
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;
                    b14.BackColor = Color.Green;
                    b14.ForeColor = Color.White;
                    b15.BackColor = Color.Green;
                    b15.ForeColor = Color.White;
                    b16.BackColor = Color.Green;
                    b16.ForeColor = Color.White;
                    if (b13.Text == "X")
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
            if (b1.Text != "" && b5.Text != "" && b9.Text != "" && b13.Text != "" )
            {
                if (b1.Text == b5.Text && b1.Text == b9.Text && b1.Text == b13.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b5.BackColor = Color.Green;
                    b5.ForeColor = Color.White;
                    b9.BackColor = Color.Green;
                    b9.ForeColor = Color.White;
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;
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
            if (b2.Text != "" && b6.Text != "" && b10.Text != "" && b14.Text != "")
            {
                if (b2.Text == b6.Text && b2.Text == b10.Text && b2.Text == b14.Text)
                {
                    b2.BackColor = Color.Green;
                    b2.ForeColor = Color.White;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b10.BackColor = Color.Green;
                    b10.ForeColor = Color.White;
                    b14.BackColor = Color.Green;
                    b14.ForeColor = Color.White;
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
            if (b3.Text != "" && b7.Text != "" && b11.Text != "" && b15.Text != "")
            {
                if (b3.Text == b7.Text && b3.Text == b11.Text && b3.Text == b15.Text)
                {
                    b3.BackColor = Color.Green;
                    b3.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b11.BackColor = Color.Green;
                    b11.ForeColor = Color.White;
                    b15.BackColor = Color.Green;
                    b15.ForeColor = Color.White;

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
            if (b4.Text != "" && b8.Text != "" && b12.Text != "" && b16.Text != "")
            {
                if (b4.Text == b8.Text && b4.Text == b12.Text && b4.Text == b16.Text)
                {
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b8.BackColor = Color.Green;
                    b8.ForeColor = Color.White;
                    b12.BackColor = Color.Green;
                    b12.ForeColor = Color.White;
                    b16.BackColor = Color.Green;
                    b16.ForeColor = Color.White;

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
            if (b1.Text != "" && b6.Text != "" && b11.Text != "" && b16.Text != "" )
            {
                if (b1.Text == b6.Text && b1.Text == b11.Text && b1.Text == b16.Text)
                {
                    b1.BackColor = Color.Green;
                    b1.ForeColor = Color.White;
                    b6.BackColor = Color.Green;
                    b6.ForeColor = Color.White;
                    b11.BackColor = Color.Green;
                    b11.ForeColor = Color.White;
                    b16.BackColor = Color.Green;
                    b16.ForeColor = Color.White;

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
            if (b4.Text != "" && b7.Text != "" && b10.Text != "" && b13.Text != "")
            {
                if (b4.Text == b7.Text && b4.Text == b10.Text && b4.Text == b13.Text)
                {
                    b4.BackColor = Color.Green;
                    b4.ForeColor = Color.White;
                    b7.BackColor = Color.Green;
                    b7.ForeColor = Color.White;
                    b10.BackColor = Color.Green;
                    b10.ForeColor = Color.White;
                    b13.BackColor = Color.Green;
                    b13.ForeColor = Color.White;

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
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" &&
                b4.Text != "" && b5.Text != "" && b6.Text != "" &&
                b7.Text != "" && b8.Text != "" && b9.Text != "" &&
                b10.Text != "" && b11.Text != "" && b12.Text != "" &&
                b13.Text != "" && b14.Text != "" && b15.Text != "" &&
                b16.Text != "")
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
            if (b1.Text == b2.Text && b1.Text == b3.Text && b4.Text == "")
            {
                if (b1.Text == "O")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b2.Text && b1.Text == b4.Text && b3.Text == "")
            {
                if (b1.Text == "O")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b3.Text && b1.Text == b4.Text && b2.Text == "")
            {
                if (b1.Text == "O")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b3.Text && b2.Text == b4.Text && b1.Text == "")
            {
                if (b2.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.1
            if (b5.Text == b6.Text && b5.Text == b7.Text && b8.Text == "")
            {
                if (b5.Text == "O")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b6.Text && b5.Text == b8.Text && b7.Text == "")
            {
                if (b5.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b8.Text && b5.Text == b7.Text && b6.Text == "")
            {
                if (b5.Text == "O")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b7.Text && b6.Text == b8.Text && b5.Text == "")
            {
                if (b6.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            //section 3.1
            if (b9.Text == b10.Text && b9.Text == b11.Text && b12.Text == "")
            {
                if (b9.Text == "O")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b9.Text == b10.Text && b9.Text == b12.Text && b11.Text == "")
            {
                if (b9.Text == "O")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b9.Text == b12.Text && b9.Text == b11.Text && b10.Text == "")
            {
                if (b9.Text == "O")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b10.Text == b11.Text && b10.Text == b12.Text && b9.Text == "")
            {
                if (b10.Text == "O")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            //section 4.1
            if (b13.Text == b14.Text && b13.Text == b15.Text && b16.Text == "")
            {
                if (b13.Text == "O")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b13.Text == b14.Text && b13.Text == b16.Text && b15.Text == "")
            {
                if (b13.Text == "O")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b13.Text == b16.Text && b13.Text == b15.Text && b14.Text == "")
            {
                if (b13.Text == "O")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b14.Text == b15.Text && b14.Text == b16.Text && b13.Text == "")
            {
                if (b14.Text == "O")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            //section 1.2
            if (b1.Text == b5.Text && b1.Text == b9.Text && b13.Text == "")
            {
                if (b1.Text == "O")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b5.Text && b1.Text == b13.Text && b9.Text == "")
            {
                if (b1.Text == "O")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b13.Text && b1.Text == b9.Text && b5.Text == "")
            {
                if (b1.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b9.Text && b5.Text == b13.Text && b1.Text == "")
            {
                if (b5.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.2
            if (b2.Text == b6.Text && b2.Text == b10.Text && b14.Text == "")
            {
                if (b2.Text == "O")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b6.Text && b2.Text == b14.Text && b10.Text == "")
            {
                if (b2.Text == "O")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b14.Text && b2.Text == b10.Text && b6.Text == "")
            {
                if (b2.Text == "O")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b10.Text && b6.Text == b14.Text && b2.Text == "")
            {
                if (b6.Text == "O")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            //section 3.2
            if (b3.Text == b7.Text && b3.Text == b11.Text && b15.Text == "")
            {
                if (b3.Text == "O")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b7.Text && b3.Text == b15.Text && b11.Text == "")
            {
                if (b3.Text == "O")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b15.Text && b3.Text == b11.Text && b7.Text == "")
            {
                if (b3.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b7.Text == b11.Text && b7.Text == b15.Text && b3.Text == "")
            {
                if (b7.Text == "O")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            //section 4.2
            if (b4.Text == b8.Text && b4.Text == b12.Text && b16.Text == "")
            {
                if (b4.Text == "O")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b8.Text && b4.Text == b16.Text && b12.Text == "")
            {
                if (b4.Text == "O")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b16.Text && b4.Text == b12.Text && b8.Text == "")
            {
                if (b4.Text == "O")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b8.Text == b12.Text && b8.Text == b16.Text && b4.Text == "")
            {
                if (b8.Text == "O")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            //section 1.2.3
            if (b1.Text == b6.Text && b1.Text == b11.Text && b16.Text == "")
            {
                if (b1.Text == "O")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b6.Text && b1.Text == b16.Text && b11.Text == "")
            {
                if (b1.Text == "O")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b16.Text && b1.Text == b11.Text && b6.Text == "")
            {
                if (b1.Text == "O")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b11.Text && b6.Text == b16.Text && b1.Text == "")
            {
                if (b6.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 3.2.1
            if (b4.Text == b7.Text && b4.Text == b10.Text && b13.Text == "")
            {
                if (b4.Text == "O")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b7.Text && b4.Text == b13.Text && b10.Text == "")
            {
                if (b4.Text == "O")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b13.Text && b4.Text == b10.Text && b7.Text == "")
            {
                if (b4.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b7.Text == b10.Text && b7.Text == b13.Text && b4.Text == "")
            {
                if (b7.Text == "O")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            return false;
        }//done v1
        private bool checkAILose()
        {
            //section 1.1
            if (b1.Text == b2.Text && b1.Text == b3.Text && b4.Text == "")
            {
                if (b1.Text == "X")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b2.Text && b1.Text == b4.Text && b3.Text == "")
            {
                if (b1.Text == "X")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b3.Text && b1.Text == b4.Text && b2.Text == "")
            {
                if (b1.Text == "X")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b3.Text && b2.Text == b4.Text && b1.Text == "")
            {
                if (b2.Text == "X")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.1
            if (b5.Text == b6.Text && b5.Text == b7.Text && b8.Text == "")
            {
                if (b5.Text == "X")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b6.Text && b5.Text == b8.Text && b7.Text == "")
            {
                if (b5.Text == "X")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b8.Text && b5.Text == b7.Text && b6.Text == "")
            {
                if (b5.Text == "X")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b7.Text && b6.Text == b8.Text && b5.Text == "")
            {
                if (b6.Text == "X")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            //section 3.1
            if (b9.Text == b10.Text && b9.Text == b11.Text && b12.Text == "")
            {
                if (b9.Text == "X")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b9.Text == b10.Text && b9.Text == b12.Text && b11.Text == "")
            {
                if (b9.Text == "X")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b9.Text == b12.Text && b9.Text == b11.Text && b10.Text == "")
            {
                if (b9.Text == "X")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b10.Text == b11.Text && b10.Text == b12.Text && b9.Text == "")
            {
                if (b10.Text == "X")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            //section 4.1
            if (b13.Text == b14.Text && b13.Text == b15.Text && b16.Text == "")
            {
                if (b13.Text == "X")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b13.Text == b14.Text && b13.Text == b16.Text && b15.Text == "")
            {
                if (b13.Text == "X")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b13.Text == b16.Text && b13.Text == b15.Text && b14.Text == "")
            {
                if (b13.Text == "X")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b14.Text == b15.Text && b14.Text == b16.Text && b13.Text == "")
            {
                if (b14.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            //section 1.2
            if (b1.Text == b5.Text && b1.Text == b9.Text && b13.Text == "")
            {
                if (b1.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b5.Text && b1.Text == b13.Text && b9.Text == "")
            {
                if (b1.Text == "X")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b13.Text && b1.Text == b9.Text && b5.Text == "")
            {
                if (b1.Text == "X")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b9.Text && b5.Text == b13.Text && b1.Text == "")
            {
                if (b5.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.2
            if (b2.Text == b6.Text && b2.Text == b10.Text && b14.Text == "")
            {
                if (b2.Text == "X")
                {
                    b14.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b6.Text && b2.Text == b14.Text && b10.Text == "")
            {
                if (b2.Text == "X")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b14.Text && b2.Text == b10.Text && b6.Text == "")
            {
                if (b2.Text == "X")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b10.Text && b6.Text == b14.Text && b2.Text == "")
            {
                if (b6.Text == "X")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            //section 3.2
            if (b3.Text == b7.Text && b3.Text == b11.Text && b15.Text == "")
            {
                if (b3.Text == "X")
                {
                    b15.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b7.Text && b3.Text == b15.Text && b11.Text == "")
            {
                if (b3.Text == "X")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b15.Text && b3.Text == b11.Text && b7.Text == "")
            {
                if (b3.Text == "X")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b7.Text == b11.Text && b7.Text == b15.Text && b3.Text == "")
            {
                if (b7.Text == "X")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            //section 4.2
            if (b4.Text == b8.Text && b4.Text == b12.Text && b16.Text == "")
            {
                if (b4.Text == "X")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b8.Text && b4.Text == b16.Text && b12.Text == "")
            {
                if (b4.Text == "X")
                {
                    b12.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b16.Text && b4.Text == b12.Text && b8.Text == "")
            {
                if (b4.Text == "X")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b8.Text == b12.Text && b8.Text == b16.Text && b4.Text == "")
            {
                if (b8.Text == "X")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            //section 1.2.3
            if (b1.Text == b6.Text && b1.Text == b11.Text && b16.Text == "")
            {
                if (b1.Text == "X")
                {
                    b16.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b6.Text && b1.Text == b16.Text && b11.Text == "")
            {
                if (b1.Text == "X")
                {
                    b11.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b16.Text && b1.Text == b11.Text && b6.Text == "")
            {
                if (b1.Text == "X")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b11.Text && b6.Text == b16.Text && b1.Text == "")
            {
                if (b6.Text == "X")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 3.2.1
            if (b4.Text == b7.Text && b4.Text == b10.Text && b13.Text == "")
            {
                if (b4.Text == "X")
                {
                    b13.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b7.Text && b4.Text == b13.Text && b10.Text == "")
            {
                if (b4.Text == "X")
                {
                    b10.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b13.Text && b4.Text == b10.Text && b7.Text == "")
            {
                if (b4.Text == "X")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b7.Text == b10.Text && b7.Text == b13.Text && b4.Text == "")
            {
                if (b7.Text == "X")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            return false;
        }// done v1
        private bool checkAICenter()
        {
            //prevent fork
            if(b11.Text == "X" && b10.Text == "X" && (b8.Text == "X" || b16.Text == "X") && b4.Text == "X" && b12.Text == "")
            {
                b12.PerformClick();
                return true;
            }
            if (b7.Text == "X" && b11.Text == "X" && (b14.Text == "X" || b16.Text == "X") && b13.Text == "X" && b15.Text == "")
            {
                b15.PerformClick();
                return true;
            }
            if (b6.Text == "X" && b10.Text == "X" && (b13.Text == "X" || b15.Text == "X") && b16.Text == "X" && b14.Text == "")
            {
                b14.PerformClick();
                return true;
            }
            if (b6.Text == "X" && b7.Text == "X" && b16.Text == "X" && b4.Text == "X" && b8.Text == "")
            {
                b8.PerformClick();
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
            if ((b11.Text != "O" || b6.Text !="O") && b7.Text == "")
            {
                b7.PerformClick();
                return true;
            }
            if ((b11.Text != "O" || b6.Text != "O") && b10.Text == "")
            {
                b10.PerformClick();
                return true;
            }
                return false;
        } // done v1
        private bool checkAICorner()
        {
            //chose another path if 5 in a row in blocked
            if(b1.Text == "")
            {
                b1.PerformClick();
                return true;
            }
            if (b6.Text == "")
            {
                b16.PerformClick();
                return true;
            }
            if (b4.Text == "")
            {
                b4.PerformClick();
                return true;
            }
            if (b13.Text == "")
            {
                b13.PerformClick();
                return true;
            }
            return false;
        }
        private bool choseRemaining()
        {
            if (b5.Text == "")
            {
                b5.PerformClick();
                return true;
            }
            if (b9.Text == "")
            {
                b9.PerformClick();
                return true;
            }
            if (b2.Text == "")
            {
                b2.PerformClick();
                return true;
            }
            if (b14.Text == "")
            {
                b14.PerformClick();
                return true;
            }
            if (b3.Text == "")
            {
                b3.PerformClick();
                return true;
            }
            if (b15.Text == "")
            {
                b15.PerformClick();
                return true;
            }
            if (b8.Text == "")
            {
                b8.PerformClick();
                return true;
            }
            if (b12.Text == "")
            {
                b12.PerformClick();
                return true;
            }
            //remain
            if (b1.Text == "")
            {
                b1.PerformClick();
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
            if (b7.Text == "")
            {
                b7.PerformClick();
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
            if (b13.Text == "")
            {
                b13.PerformClick();
                return true;
            }
            if (b16.Text == "")
            {
                b16.PerformClick();
                return true;
            }
            return false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
                {
                    clearGame();
                    player = 0;
                    cp = 0;
                    playerScore.Text = "Player       = " + player;
                    cpScore.Text = "Computer = " + cp;
                }
        } // done v1

        
    }
}
