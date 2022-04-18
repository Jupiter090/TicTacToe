using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        
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
            //App styles
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            GameName.Left = (int)(this.Size.Width / 2.5F);
            GameName.Top = (int)(this.Size.Height / 5F);
            Play.Left = (int)(this.Size.Width / 2.325);
            Play.Top = (int)(this.Size.Height / 3.5f);
            Exit.Left = (int)(this.Size.Width / 2.325);
            Exit.Top = (int)(this.Size.Height / 2.75f);
            string hostName = Dns.GetHostName();

        }

        private void Play_Click(object sender, EventArgs e)
        {
            //Opens choose gamemode screen
            choose_gamemode gamemode = new choose_gamemode();
            gamemode.FormClosed += new FormClosedEventHandler(Game_FormClosed);
            gamemode.Show();
            this.Hide();
        }
        void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                this.Show();
            }
        }
    }
}
