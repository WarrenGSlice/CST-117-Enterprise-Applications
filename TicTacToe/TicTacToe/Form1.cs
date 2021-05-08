using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* * * * * * * * * * *
 * Warren Peterson * *
 * This is my own Work
 * CST-117 * 5/7/2021*
 * ProgrammingProject4
 * * Tic Tac Toe Game*
 * * * * * * * * * * */
namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Variables
        bool turn = true; //true = X turn, false = O turn
        int turn_count = 0; // Variable to keep track of turn count
        
        public Form1()
        {
            InitializeComponent();
        }
        // Menu Strip Item for About Program
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Warren Peterson", "Tic Tac Toe About");
        }
        // Menu Strip Item to Exit game from Menu
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Method button click activates whenever a field is clicked
        // Checks a number of things each click to see what happens
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender; // creates a variable for the button clicking event
            // Loop that says if its X's turn, the field will print X,
            //If it is O's turn, the field will print O
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn; // changes who's turn it is each click
            b.Enabled = false; // disabled buttons after they are clicked
            turn_count++; //increments and keeps track of how many turns there has been
            whoWon(); // Invokes the whoWon() Method to see if someone won and what to do if
        }
        // The whoWon method checks to see if someone who and created a two-dimensional array that matches the game board
        private void whoWon()
        {
            // Variables
            bool isWinner = false; // variable to see if someone won or not. 
            // Creates a two-dimensional array to hold the inputs of the gameboard
            string[,] board = { { Top1.Text, Top2.Text, Top3.Text},
                                 { Middle1.Text, Middle2.Text, Middle3.Text},
                                 { Bottom1.Text, Bottom2.Text, Bottom3.Text}};
            board[0, 0] = (Top1.Text).ToString(); // Converts ints to strings
            board[0, 1] = (Top2.Text).ToString();
            board[0, 2] = (Top3.Text).ToString();
            board[1, 0] = (Middle1.Text).ToString();
            board[1, 1] = (Middle2.Text).ToString();
            board[1, 2] = (Middle3.Text).ToString();
            board[2, 0] = (Bottom1.Text).ToString();
            board[2, 1] = (Bottom2.Text).ToString();
            board[2, 2] = (Bottom3.Text).ToString();

            // Horizontal Checks
            if ((board[0,0] == board[0,1]) && (board[0,1] == board[0,2]) && (!Top1.Enabled))
            {
                isWinner = true;
            }
            if ((board[1, 0] == board[1, 1]) && (board[1, 1] == board[1, 2]) && (!Middle1.Enabled))
            {
                isWinner = true;
            }
            if ((board[2, 0] == board[2, 1]) && (board[2, 1] == board[2, 2]) && (!Bottom1.Enabled))
            {
                isWinner = true;
            }

            // Verticle Checks
            if ((board[0, 0] == board[1, 0]) && (board[1, 0] == board[2, 0]) && (!Top1.Enabled))
            {
                isWinner = true;
            }
            if ((board[0, 1] == board[1, 1]) && (board[1, 1] == board[2, 1]) && (!Top2.Enabled))
            {
                isWinner = true;
            }
            if ((board[0, 2] == board[1, 2]) && (board[1, 2] == board[2, 2]) && (!Top3.Enabled))
            {
                isWinner = true;
            }

            //Diagonal Checks
            if ((Top1.Text == board[1, 1]) && (board[1, 1] == board[2, 2]) && (!Top1.Enabled))
            {
                isWinner = true;
            }
            if ((board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]) && (!Top3.Enabled))
            {
                isWinner = true;
            }

            // Loop checks if there is a winning match, if there is it displays a winner message
            // and also keeps track of the win count
            if (isWinner)
            {
                disableButtons();
                string Winner = "";
                if (turn)
                {
                    Winner = "O";
                    OwinCounterTextBox.Text = (Int32.Parse(OwinCounterTextBox.Text) + 1).ToString();
                }
                else
                {
                    Winner = "X";
                    XwinCounterTextBox.Text = (Int32.Parse(XwinCounterTextBox.Text) + 1).ToString();
                }
                MessageBox.Show(Winner + " Won Tic Tac Toe", "Congratulations!");
            }
            else
            {
                if (turn_count == 9)
                {
                    DrawCounterTextBox.Text = (Int32.Parse(DrawCounterTextBox.Text) + 1).ToString();
                    MessageBox.Show("This Match was a Draw!", "Stalemate!");
                }
            }
        }
        // Method to disable the buttons
        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }// end foreach
            } // end try
            catch { }
        }// end disable buttons
        // Method to start a new game when the new game menu item is selected
        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch { }
                }
            
        }
        // Method for what happens when a player hovers the mouse over a button
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            } //end if
        }
        // Method for what happens when a player is no longer hovering over a button
        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            } // end if
        }
        // Method for setting the win counters
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwinCounterTextBox.Text = "0";
            XwinCounterTextBox.Text = "0";
            DrawCounterTextBox.Text = "0";
        }
    }
}
