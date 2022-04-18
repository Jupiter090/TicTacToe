using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class CreateOrJoinLan : Form
    {
        public static string port = null;
        public CreateOrJoinLan()
        {
            InitializeComponent();
        }

        private void CreateOrJoinLan_Load(object sender, EventArgs e)
        {
            //Fullsreen the window
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //Buttons
            GoBack.Top = (int)(this.Size.Height / 1.15);
            GoBack.Left = (int)(this.Size.Width / 2.325);
            //ss
            Host.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateLAN_Click(object sender, EventArgs e)
        {
            //Runs a LAN host game
            port = Port.Text;
            LANPlvsPlHost plvsplHost = new LANPlvsPlHost();
            plvsplHost.Show();

            Hide();
            plvsplHost.FormClosed += new FormClosedEventHandler(Game_close);
        }
        private void Game_close(object sender, FormClosedEventArgs e)
        {
            Show();
        }

    }
}
