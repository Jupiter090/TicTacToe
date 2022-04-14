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
        static int round = 0;

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
            PlayAgain.Visible = false;
            PlayAgain.Top = (int)(this.Size.Height / 7f);
            PlayAgain.Left = (int)(this.Size.Width / 2.18f);
            wins.Text = "Wins:\nPlayer1: " + Program.wins_p1 + "\nPlayer2: " + Program.wins_p2;
        }

        private void customButtons3_Click(object sender, EventArgs e)
        {
            choose_gamemode.closedFromButton = true;
            this.Close();
        }
        private void onGridClick(object sender, EventArgs e)
        {
            if((sender as Button).Text == "")
            {
                if(round == 0)
                {
                    (sender as Button).Text = "X";
                    round = 1;
                }
                else if (round == 1)
                {
                    (sender as Button).Text = "O";
                    round = 0;
                }
            }
        }
    }
}
