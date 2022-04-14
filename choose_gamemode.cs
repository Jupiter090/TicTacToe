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
        public choose_gamemode()
        {
            InitializeComponent();
        }

        private void choose_gamemode_Load(object sender, EventArgs e)
        {
            //Fullsreen the window
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            PlvsPl.Left = (int)(this.Size.Width / 2.325);
            PlvsPl.Top = (int)(this.Size.Height / 3.5f);
            PlvsB.Left = (int)(this.Size.Width / 2.325);
            PlvsB.Top = (int)(this.Size.Height / 2.75f);
            GoBack.Left = (int)(this.Size.Width / 2.325);
            GoBack.Top = (int)(this.Size.Height / 2.25);
            Gamemode.Left = (int)(this.Size.Width / 2.95F);
            Gamemode.Top = (int)(this.Size.Height / 5F);
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
        void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (playAgain == true)
            {
                this.Show();
                PlvsB.PerformClick();
                this.Hide();
                playAgain = false;
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
