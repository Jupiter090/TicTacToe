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
    public partial class Game : Form
    {
        private int count;
        private bool canRun = true;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Fullsreen the window
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            customButtons3.Left = (int)(this.Size.Width/ 1.15f);
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
            PlayAgain.Visible = false;
            PlayAgain.Top = (int)(this.Size.Height / 7f);
            PlayAgain.Left = (int)(this.Size.Width / 2.18f);
            wins.Text = "Wins:\nPlayer: " + Program.wins_p + "\nRobot: " + Program.wins_r;

        }

        private void customButtons3_Click(object sender, EventArgs e)
        {
            choose_gamemode.closedFromButton = true;
            this.Close();
        }

        async private void onGridClick(object sender, EventArgs e)
        {
            if (canRun)
            {
                //Plays robots AI when player click
                if ((sender as Button).Text == "")
                {
                    (sender as Button).Text = "X";
                    await Task.Delay(250);
                    computerAI();
                }
            }
        }
        private void computerAI()
        {
            count++;
            if (CheckOnWin("X") && canRun){
                canRun = false;
                Program.wins_p++;
                wins.Text = "Wins:\nPlayer: " + Program.wins_p + "\nRobot: " + Program.wins_r;
                return;
            }
            if (CheckOnFullGrid())
            {
                return;
            }
            //Random generates grid where computer will click
            Random rnd = new Random();
            int random = rnd.Next(1, 10);
            switch (random)
            {
                case 1:
                    if (place1.Text == "")
                    {
                        place1.Text = "O";
                        return;
                    }
                    break;
                case 2:
                    if (place2.Text == "")
                    {
                        place2.Text = "O";
                        return;
                    }
                    break;
                case 3:
                    if (place3.Text == "")
                    {
                        place3.Text = "O";
                        return;
                    }
                    break;
                case 4:
                    if (place4.Text == "")
                    {
                        place4.Text = "O";
                        return;
                    }
                    break;
                case 5:
                    if (place5.Text == "")
                    {
                        place5.Text = "O";
                        return;
                    }
                    break;
                case 6:
                    if (place6.Text == "")
                    {
                        place6.Text = "O";
                        return;
                    }
                    break;
                case 7:
                    if (place7.Text == "")
                    {
                        place7.Text = "O";
                        return;
                    }
                    break;
                case 8:
                    if (place8.Text == "")
                    {
                        place8.Text = "O";
                        return;
                    }
                    break;
                case 9:
                    if (place9.Text == "")
                    {
                        place9.Text = "O";
                        return;
                    }
                    break;

            }
            if (CheckOnLoose("O") && canRun)
            {
                Program.wins_r++;
                canRun = false;
                wins.Text = "Wins:\nPlayer: " + Program.wins_p + "\nRobot: " + Program.wins_r;
                return;
            }
            if (count == 100)
            {
                count = 0;
                if(place1.Text == "")
                {
                    place1.Text = "O";
                }else if (place2.Text == "")
                {
                    place2.Text = "O";
                }
                else if (place3.Text == "")
                {
                    place3.Text = "O";
                }
                else if (place4.Text == "")
                {
                    place4.Text = "O";
                }
                else if (place5.Text == "")
                {
                    place5.Text = "O";
                }
                else if (place6.Text == "")
                {
                    place6.Text = "O";
                }
                else if (place7.Text == "")
                {
                    place7.Text = "O";
                }
                else if (place8.Text == "")
                {
                    place8.Text = "O";
                }
                else if (place9.Text == "")
                {
                    place9.Text = "O";
                }
                if (CheckOnLoose("O") && canRun)
                {
                    canRun = false;
                    Program.wins_r++;
                    wins.Text = "Wins:\nPlayer: " + Program.wins_p + "\nRobot: " + Program.wins_r;
                    return;
                }
                return;
            }

            computerAI();
        }
        private bool CheckOnFullGrid()
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
            choose_gamemode.playAgain = true;
            this.Close();
        }
        private bool CheckOnWin(string player)
        {
            if (place7.Text == player && place8.Text == player && place9.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }else if (place4.Text == player && place5.Text == player && place6.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place1.Text == player && place2.Text == player && place3.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place1.Text == player && place4.Text == player && place7.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place2.Text == player && place5.Text == player && place8.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place3.Text == player && place6.Text == player && place9.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place1.Text == player && place5.Text == player && place9.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place3.Text == player && place5.Text == player && place7.Text == player)
            {
                GameOver.Text = "Win!";
                PlayAgain.Visible = true;
                return true;
            }
            return false;
        }
        private bool CheckOnLoose(string player)
        {
            if (place7.Text == player && place8.Text == player && place9.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place4.Text == player && place5.Text == player && place6.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place1.Text == player && place2.Text == player && place3.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place1.Text == player && place4.Text == player && place7.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place2.Text == player && place5.Text == player && place8.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place3.Text == player && place6.Text == player && place9.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place1.Text == player && place5.Text == player && place9.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            else if (place3.Text == player && place5.Text == player && place7.Text == player)
            {
                GameOver.Text = "Lost!";
                PlayAgain.Visible = true;
                return true;
            }
            return false;
        }
    }
}
