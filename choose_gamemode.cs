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
    public partial class choose_gamemode : Form
    {
        static public bool closedFromButton = false;
        static public bool playAgain = false;
        static public bool playAgainPl = false;
        public choose_gamemode()
        {
            InitializeComponent();
        }

        private void choose_gamemode_Load(object sender, EventArgs e)
        {
            //Fullsreen the window
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Open a new game depending on gamemode and add close event
        private void PlvsB_Click(object sender, EventArgs e)
        {
            Form game = new Game();
            game.Show();
            game.FormClosed += new FormClosedEventHandler(Game_FormClosed);
            this.Hide();
        }
        private void PlvsPl_Click(object sender, EventArgs e)
        {
            Form game = new Game_plvspl();
            game.Show();
            game.FormClosed += new FormClosedEventHandler(Game_FormClosed);
            this.Hide();

        }
        private void LAN_Click(object sender, EventArgs e)
        {
            Form LAN = new CreateOrJoinLan();
            LAN.Show();
            LAN.FormClosed += new FormClosedEventHandler(Game_FormClosed);
            Hide();
        }

        //If player want to play again new windows is opend if not choose gamemode screen appears
        void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (playAgain == true)
            {
                this.Show();
                PlvsB.PerformClick();
                this.Hide();
                playAgain = false;
                return;
            }else if (playAgainPl == true)
            {
                this.Show();
                PlvsPl.PerformClick();
                this.Hide();
                playAgainPl = false;
                return;
            }
            else if (closedFromButton == true)
            {
                this.Show();
                closedFromButton = false;
            }
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Show();
            }
        }

    }
}
