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
         *in this game 'X' alwasys starts first
         */
        private int turn = 1;
        //an integer for keeping track of number of turns
        private int noTurn = 0;

        /*
         *two integers for keeping track of number of wins  
         */
        private int player = 0;
        private int cp = 0;

        public Grid3()
        {
            InitializeComponent();
        }
        // a method to change the players turn and count number of turns
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
        //a method to reset game and scorings
        private void resetBtn_Click(object sender, EventArgs e)
        {
            clearGame();
            player = 0;
            cp = 0;
            playerScore.Text = "Player       = " + player;
            cpScore.Text = "Computer = " + cp;

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
                 b7.Text != "" && b8.Text != "" && b9.Text != "")
             {
                 MessageBox.Show("Draw!");
                 clearGame();
             }

        }
        // a method to clear the game after a player has won
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
        //AI Section
        /* 
         * AI Logic: 
         * First move to check if the ai can win
         * Second move if the ai can lose (to prevent it)
         * If there is a configuration where the opponent can fork, you must block that fork
         * (the ai cant create a fork itself because he does not have the first move)
         * play the center if open.
         * Else take corner
         * play in a middle square on any of the 4 sides
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
            if (b1.Text == b2.Text && b3.Text == "")
            {
                if (b1.Text == "O")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b3.Text && b2.Text == "")
            {
                if (b1.Text == "O")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b2.Text && b1.Text == "")
            {
                if (b3.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            // section 2.1
            if (b4.Text == b5.Text && b6.Text == "")
            {
                if (b4.Text == "O")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b6.Text && b5.Text == "")
            {
                if (b4.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b6.Text && b4.Text == "")
            {
                if (b5.Text == "O")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            //section 3.1
            if (b7.Text == b8.Text && b9.Text == "")
            {
                if (b6.Text == "O")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b7.Text == b9.Text && b8.Text == "")
            {
                if (b7.Text == "O")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b8.Text == b9.Text && b7.Text == "")
            {
                if (b8.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            //section 1.2
            if (b1.Text == b4.Text && b7.Text == "")
            {
                if (b1.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b7.Text && b4.Text == "")
            {
                if (b1.Text == "O")
                {
                    b4.PerformClick();
                    return true;
                }
            }
            if (b4.Text == b7.Text && b1.Text == "")
            {
                if (b4.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            //section 2.2
            if (b2.Text == b5.Text && b8.Text == "")
            {
                if (b2.Text == "O")
                {
                    b8.PerformClick();
                    return true;
                }
            }
            if (b2.Text == b8.Text && b5.Text == "")
            {
                if (b2.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b8.Text && b2.Text == "")
            {
                if (b5.Text == "O")
                {
                    b2.PerformClick();
                    return true;
                }
            }
            // section 3.2
            if (b3.Text == b6.Text && b9.Text == "")
            {
                if (b3.Text == "O")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b9.Text && b6.Text == "")
            {
                if (b3.Text == "O")
                {
                    b6.PerformClick();
                    return true;
                }
            }
            if (b6.Text == b9.Text && b3.Text == "")
            {
                if (b6.Text == "O")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            // secton 1.2.3
            if (b1.Text == b5.Text && b9.Text == "")
            {
                if (b1.Text == "O")
                {
                    b9.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b9.Text && b1.Text == "")
            {
                if (b5.Text == "O")
                {
                    b1.PerformClick();
                    return true;
                }
            }
            if (b1.Text == b9.Text && b5.Text == "")
            {
                if (b1.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }
            // section 3.2.1
            if (b3.Text == b5.Text && b7.Text == "")
            {
                if (b3.Text == "O")
                {
                    b7.PerformClick();
                    return true;
                }
            }
            if (b5.Text == b7.Text && b3.Text == "")
            {
                if (b5.Text == "O")
                {
                    b3.PerformClick();
                    return true;
                }
            }
            if (b3.Text == b7.Text && b5.Text == "")
            {
                if (b3.Text == "O")
                {
                    b5.PerformClick();
                    return true;
                }
            }

            return false;
            
        }
        private bool checkAILose()
        {

            {
                //section 1.1
                if (b1.Text == b2.Text && b3.Text == "")
                {
                    if (b1.Text == "X")
                    {
                        b3.PerformClick();
                        return true;
                    }
                }
                if (b1.Text == b3.Text && b2.Text == "")
                {
                    if (b1.Text == "X")
                    {
                        b2.PerformClick();
                        return true;
                    }
                }
                if (b3.Text == b2.Text && b1.Text == "")
                {
                    if (b3.Text == "X")
                    {
                        b1.PerformClick();
                        return true;
                    }
                }
                // section 2.1
                if (b4.Text == b5.Text && b6.Text == "")
                {
                    if (b4.Text == "X")
                    {
                        b6.PerformClick();
                        return true;
                    }
                }
                if (b4.Text == b6.Text && b5.Text == "")
                {
                    if (b4.Text == "X")
                    {
                        b5.PerformClick();
                        return true;
                    }
                }
                if (b5.Text == b6.Text && b4.Text == "")
                {
                    if (b5.Text == "X")
                    {
                        b4.PerformClick();
                        return true;
                    }
                }
                //section 3.1
                if (b7.Text == b8.Text && b9.Text == "")
                {
                    if (b7.Text == "X")
                    {
                        b9.PerformClick();
                        return true;
                    }
                }
                if (b7.Text == b9.Text && b8.Text == "")
                {
                    if (b7.Text == "X")
                    {
                        b8.PerformClick();
                        return true;
                    }
                }
                if (b8.Text == b9.Text && b7.Text == "")
                {
                    if (b8.Text == "X")
                    {
                        b7.PerformClick();
                        return true;
                    }
                }
                //section 1.2
                if (b1.Text == b4.Text && b7.Text == "")
                {
                    if (b1.Text == "X")
                    {
                        b7.PerformClick();
                        return true;
                    }
                }
                if (b1.Text == b7.Text && b4.Text == "")
                {
                    if (b1.Text == "X")
                    {
                        b4.PerformClick();
                        return true;
                    }
                }
                if (b4.Text == b7.Text && b1.Text == "")
                {
                    if (b4.Text == "X")
                    {
                        b1.PerformClick();
                        return true;
                    }
                }
                //section 2.2
                if (b2.Text == b5.Text && b8.Text == "")
                {
                    if (b2.Text == "X")
                    {
                        b8.PerformClick();
                        return true;
                    }
                }
                if (b2.Text == b8.Text && b5.Text == "")
                {
                    if (b2.Text == "X")
                    {
                        b5.PerformClick();
                        return true;
                    }
                }
                if (b5.Text == b8.Text && b2.Text == "")
                {
                    if (b5.Text == "X")
                    {
                        b2.PerformClick();
                        return true;
                    }
                }
                // section 3.2
                if (b3.Text == b6.Text && b9.Text == "")
                {
                    if (b3.Text == "X")
                    {
                        b9.PerformClick();
                        return true;
                    }
                }
                if (b3.Text == b9.Text && b6.Text == "")
                {
                    if (b3.Text == "X")
                    {
                        b6.PerformClick();
                        return true;
                    }
                }
                if (b6.Text == b9.Text && b3.Text == "")
                {
                    if (b6.Text == "X")
                    {
                        b3.PerformClick();
                        return true;
                    }
                }
                // secton 1.2.3
                if (b1.Text == b5.Text && b9.Text == "")
                {
                    if (b1.Text == "X")
                    {
                        b9.PerformClick();
                        return true;
                    }
                }
                if (b5.Text == b9.Text && b1.Text == "")
                {
                    if (b5.Text == "X")
                    {
                        b1.PerformClick();
                        return true;
                    }
                }
                if (b1.Text == b9.Text && b5.Text == "")
                {
                    if (b1.Text == "X")
                    {
                        b5.PerformClick();
                        return true;
                    }
                }
                // section 3.2.1
                if (b3.Text == b5.Text && b7.Text == "")
                {
                    if (b3.Text == "X")
                    {
                        b7.PerformClick();
                        return true;
                    }
                }
                if (b5.Text == b7.Text && b3.Text == "")
                {
                    if (b5.Text == "X")
                    {
                        b3.PerformClick();
                        return true;
                    }
                }
                if (b3.Text == b7.Text && b5.Text == "")
                {
                    if (b3.Text == "X")
                    {
                        b5.PerformClick();
                        return true;
                    }
                }

                return false;

            }
        }
        private bool checkAICenter()
        {
            if(b5.Text == "")
            {
                b5.PerformClick();
                return true;
            }
            else 
                return false;
        }
        private bool checkAICorner()
        {
            // Blocking an opponent's fork
            if ((b1.Text == "X" && b9.Text == "X") || (b3.Text == "X" && b7.Text == "X"))
               return false;
            if (b8.Text == "X" && b3.Text == "X" && noTurn == 3)
                return false;
            if (b1.Text == "X" && b8.Text == "X" && noTurn == 3)
                return false;

            if(b6.Text == "X" && b8.Text == "X" && noTurn == 3)
            {
                b9.PerformClick();
                return true;
            }
            if(b1.Text == "")
            {
                b1.PerformClick();
                return true;
            }
            if (b3.Text == "")
            {
                b3.PerformClick();
                return true;
            }
            if (b7.Text == "")
            {
                b7.PerformClick();
                return true;
            }
            if (b9.Text == "")
            {
                b9.PerformClick();
                return true;
            }
            return false;
        }
        private bool choseRemaining()
        {
            if (b8.Text == "X" && b3.Text == "X" && noTurn == 3)
            {
                b9.PerformClick();
                return true;
            }
            if (b1.Text == "X" && b8.Text == "X" && noTurn == 3)
            {
                b7.PerformClick();
                return true;
            }
            if (b2.Text == "")
            {
                b2.PerformClick();
                return true;
            }
            if(b4.Text == "")
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
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void playerScore_Click(object sender, EventArgs e)
        {

        }

        private void cpScore_Click(object sender, EventArgs e)
        {

        } 
    }
}
