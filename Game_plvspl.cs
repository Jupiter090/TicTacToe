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
    public partial class Game_plvspl : Form
    {
        //Determines wich player is playing

        public Game_plvspl()
        {
            InitializeComponent();
        }

        private void Game_plvspl_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //Game over text
            GameOver.Text = null;
            GameOverWin.Text = null;
            PlayAgain.Visible = false;;
            wins.Text = "Wins:\nPlayer1[X]: " + Program.wins_p1 + "\nPlayer2[O]: " + Program.wins_p2;
        }

        private void customButtons3_Click(object sender, EventArgs e)
        {
            choose_gamemode.closedFromButton = true;
            this.Close();
        }
        private void onGridClick(object sender, EventArgs e)
        {
            //Check if slot is empty
            if((sender as Button).Text == "")
            {
                //Depending of which players is round it will place symbol
                if(Program.round == 0)
                {
                    (sender as Button).Text = "X";
                    Program.round = 1;
                }
                else if (Program.round == 1)
                {
                    (sender as Button).Text = "O";
                    Program.round = 0;
                }
                //Checks for every player if won
                if (CheckOnPlayerWin("X"))
                {
                    Program.wins_p1++;
                    wins.Text = "Wins:\nPlayer1[X]: " + Program.wins_p1 + "\nPlayer2[O]: " + Program.wins_p2;
                }
                else if (CheckOnPlayerWin("O"))
                {
                    Program.wins_p2++;
                    wins.Text = "Wins:\nPlayer1[X]: " + Program.wins_p1 + "\nPlayer2[O]: " + Program.wins_p2;
                }
                //Checks if it's a tie
                else if (checkOnFullGrid()){}
            }
        }
        private bool CheckOnPlayerWin(string player)
        {
            if(player == "X")
            {
                if(place7.Text == player && place8.Text == player && place9.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }else if (place6.Text == player && place5.Text == player && place4.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place3.Text == player && place2.Text == player && place1.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place7.Text == player && place4.Text == player && place1.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place8.Text == player && place5.Text == player && place2.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place9.Text == player && place6.Text == player && place3.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place1.Text == player && place5.Text == player && place9.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place7.Text == player && place5.Text == player && place3.Text == player)
                {
                    GameOverWin.Text = "Player1 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
            }
            if (player == "O")
            {
                if (place7.Text == player && place8.Text == player && place9.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place6.Text == player && place5.Text == player && place4.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place3.Text == player && place2.Text == player && place1.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place7.Text == player && place4.Text == player && place1.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place8.Text == player && place5.Text == player && place2.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place9.Text == player && place6.Text == player && place3.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place1.Text == player && place5.Text == player && place9.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
                else if (place7.Text == player && place5.Text == player && place3.Text == player)
                {
                    GameOverWin.Text = "Player2 Won!";
                    PlayAgain.Visible = true;
                    return true;
                }
            }
            return false;
        }
        private bool checkOnFullGrid()
        {
            if (place1.Text != "" && place2.Text != "" && place3.Text != "" && place4.Text != "" && place5.Text != "" && place6.Text != "" && place7.Text != "" && place8.Text != "" && place9.Text != "")
            {
                GameOver.Text = "Tie!";
                PlayAgain.Visible = true;
                return true;
            }

            return false;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            //Creates a new game
            choose_gamemode.playAgainPl = true;
            this.Close();
        }

        private void GameOver_Click(object sender, EventArgs e)
        {

        }

        private void GameOverWin_Click(object sender, EventArgs e)
        {

        }
    }
}
