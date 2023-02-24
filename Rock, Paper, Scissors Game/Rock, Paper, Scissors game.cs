using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors_Game
{

    public partial class rockPaperScissorsGame : Form
    {
        Random rand = new Random(); //makes a random number
        private int computerPick = 0; // holds the user pick
        private int userPick = 0; //holds the user pick
        private int computerTotal = 0; // holds how many times the computer won
        private int userTotal = 0; // holds how many times the user won
        private int ties = 0; //holds how many times the user nad computer tied
        private int userPickTwo; // the holder for the user pick after the return
        private int computerPickTwo; //the new holder for the computer pick after the return

        public rockPaperScissorsGame()
        {
            InitializeComponent();
        }

        public int userPickNumber(int userPick)
        { //returns the userpick to userPickNumber
            return userPick;
        }

        public int computerPickNumber(int ComputerPick)
        {//returns the computerPIck to computerPickNumber
            return computerPick = rand.Next(1, 6);
        }

        private void btnPlayGmae_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out userPick)) //turns what the user put in into a int
          
                userPickTwo = userPickNumber(userPick);//user pick after return

            if (userPickTwo >= 1 && userPick <= 6)//checks what the user puts in 
            {
                //puts what the user picked on the screen
                if (userPickTwo == 1)
                    lblUserPickShow.Text = "You picked Rock";
                else if (userPickTwo == 2)
                    lblUserPickShow.Text = "You picked Paper";
                else if (userPickTwo == 3)
                    lblUserPickShow.Text = "You picked Scissors";
                else if (userPickTwo == 4)
                    lblUserPickShow.Text = "You picked Lizard";
                else if (userPickTwo == 5)
                    lblUserPickShow.Text = "You picked Spock";

            computerPickTwo = computerPickNumber(computerPick);//computer pick after return

            //puts what the user picked on the screen
            if (computerPickTwo == 1)
                lblComputerPIckShow.Text = "The computer picked Rock";
            else if (computerPickTwo == 2)
                lblComputerPIckShow.Text = "The computer picked Paper";
            else if (computerPickTwo == 3)
                lblComputerPIckShow.Text = "The computer picked Scissors";
            else if (computerPickTwo == 4)
                lblComputerPIckShow.Text = "The computer picked Lizard";
            else if (computerPickTwo == 5)
                lblComputerPIckShow.Text = "The computer picked Spock";

            // This is when the player wins and the computer loses 
            if (userPickTwo == 3 && computerPickTwo == 2)
            {
                txtNumber.Text = ""; //clears the text box 
                lblResultsShow.Text = "Scissors cuts paper 'you won'";//show the user the result
                userTotal++; //adds one to the user win total
                userPickTwo = 0; //makes it where the user has to pick a new number
                }
            else if (userPick == 2 && computerPick == 1)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Paper covers rock 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 1 && computerPick == 4)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Rock crushes lizard 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 4 && computerPick == 5)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Lizard posions spock 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 5 && computerPick == 3)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Spock smashes scissors 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 3 && computerPick == 4)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Scissors decapitates lizard 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 4 && computerPick == 2)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Lizard eats paper 'you won'";
                userTotal++;
                userPickTwo = 0;

                }
            else if (userPick == 2 && computerPick == 5)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Paper disproves spock 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 5 && computerPick == 1)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Spock vaporizes rock 'you won'";
                userTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 1 && computerPick == 3)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Rock crushes scissors 'you won'";
                userTotal++;
                userPickTwo = 0;
                }

            // This is when the computer wins and the player loses 
            else if (userPickTwo == 2 && computerPickTwo == 3)
            {
                txtNumber.Text = "";//clears the text box 
                lblResultsShow.Text = "Scissors cuts paper 'you lost'";//show the user the result
                computerTotal++; // adds one to the computer win total
                userPickTwo = 0; //makes it where the user has to pick a new number
                }
            else if (userPick == 1 && computerPick == 2)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Paper covers rock 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 4 && computerPick == 1)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Rock crushes lizard 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 5 && computerPick == 4)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Lizard posions spock 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 3 && computerPick == 5)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Spock smashes scissors 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 4 && computerPick == 3)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Scissors decapitates lizard 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 2 && computerPick == 4)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Lizard eats paper 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 5 && computerPick == 2)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Paper disproves spock 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 1 && computerPick == 5)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Spock vaporizes rock 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }
            else if (userPick == 3 && computerPick == 1)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "Rock crushes scissors 'you lost'";
                computerTotal++;
                userPickTwo = 0;
                }

            // This is for ties
            else if (userPick == 1 && computerPick == 1)
            {
                txtNumber.Text = "";//clears the text box 
                lblResultsShow.Text = "It is a tie "; //show the user the result
                ties++; // adds one to the tie total
                userPickTwo = 0; //makes it where the user has to pick a new number
                }
            else if (userPick == 2 && computerPick == 2)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "It is a tie ";
                ties++;
                userPickTwo = 0;
                }
            else if (userPick == 3 && computerPick == 3)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "It is a tie ";
                ties++;
                userPickTwo = 0;
                }
            else if (userPick == 4 && computerPick == 4)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "It is a tie ";
                ties++;
                userPickTwo = 0;
                }
            else if (userPick == 5 && computerPick == 5)
            {
                txtNumber.Text = "";
                lblResultsShow.Text = "It is a tie ";
                ties++;
                userPickTwo = 0;
                }
            // show sthe output of how many times the user won, the computer won, and ties
            lblWonTheMostShow.Text = "You won " + userTotal + " times" + "\n\nThe computer won " + computerTotal + " times" + "\n\nYou tied " + ties + " times";
        }else{
                MessageBox.Show("Please pick a number between 1 and 5");//If the user picks something other then 1 through 5
        }
      }

        private void btnReset_Click(object sender, EventArgs e)
        {//reset the score back to 0 and clears the labels
            txtNumber.Text = "";
            lblUserPickShow.Text = "";
            lblComputerPIckShow.Text = "";
            lblWonTheMostShow.Text = "";
            lblResultsShow.Text = "";
            computerTotal = 0;
            userTotal = 0;
            ties = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {//This closes the program 
            this.Close();
        }
    }
}
