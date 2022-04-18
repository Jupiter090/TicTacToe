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
            customButtons3.Left = (int)(this.Size.Width / 1.15f);
            customButtons3.Top = (int)(this.Size.Height / 1.1f);
            //Sets buttons positon and centres grid
            place1.Left = (int)(this.Size.Width / 2.35f);
            place1.Top = (int)(this.Size.Height / 4f);
            place2.Left = (int)(this.Size.Width / 2.05f);
            place2.Top = (int)(this.Size.Height / 4f);
            place3.Left = (int)(this.Size.Width / 1.8175f);
            place3.Top = (int)(this.Size.Height / 4f);
            place4.Left = (int)(this.Size.Width / 2.35f);
            place4.Top = (int)(this.Size.Height / 2.70f);
            place5.Left = (int)(this.Size.Width / 2.05f);
            place5.Top = (int)(this.Size.Height / 2.70f);
            place6.Left = (int)(this.Size.Width / 1.8175f);
            place6.Top = (int)(this.Size.Height / 2.70f);
            place7.Left = (int)(this.Size.Width / 2.35f);
            place7.Top = (int)(this.Size.Height / 2.045f);
            place8.Left = (int)(this.Size.Width / 2.05f);
            place8.Top = (int)(this.Size.Height / 2.045f);
            place9.Left = (int)(this.Size.Width / 1.8175f);
            place9.Top = (int)(this.Size.Height / 2.045f);
            //Game over text
            GameOver.Text = null;
            GameOver.Top = (int)(this.Size.Height / 17f);
            GameOver.Left = (int)(this.Size.Width / 2.075f);
            GameOverWin.Text = null;
            GameOverWin.Top = (int)(this.Size.Height / 17f);
            GameOverWin.Left = (int)(this.Size.Width / 2.40f);
            PlayAgain.Visible = false;
            PlayAgain.Top = (int)(this.Size.Height / 7f);
            PlayAgain.Left = (int)(this.Size.Width / 2.18f);
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
    }
}
