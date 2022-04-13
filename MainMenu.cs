using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        static public bool closedFromButton = false;
        static public bool playAgain = false;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void customButtons1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            GameName.Left = (int)(this.Size.Width / 2.5F);
            GameName.Top = (int)(this.Size.Height / 5F);
            Play.Left = (int)(this.Size.Width / 2.325);
            Play.Top = (int)(this.Size.Height / 3.5f);
            Exit.Left = (int)(this.Size.Width / 2.325);
            Exit.Top = (int)(this.Size.Height / 2.75f);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.FormClosed += new FormClosedEventHandler(Game_FormClosed);
            game.Show();
            this.Hide();
        }
        void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(playAgain == true)
            {
                this.Show();
                Play.PerformClick();
                this.Hide();
                playAgain = false;
                return;
            }
            else if(closedFromButton == true)
            {
                this.Show();
                closedFromButton = false;
            }
        }
    }
}
