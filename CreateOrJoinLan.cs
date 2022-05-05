using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class CreateOrJoinLan : Form
    {
        public static string port = null;
        public static string host_join = null;
        public static string port_join = null;
        public static string close = null;
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
            //Checks if user has internet
            if (!CheckOnInternetConnection())
            {
                txtError.Text = "There was an error while trying to create LAN game!";
                return;
            }
            //Runs a LAN host game
            port = Port.Text;
            LANPlvsPlHost plvsplHost = new LANPlvsPlHost();
            plvsplHost.Show();

            txtError.Text = "";

            Hide();
            plvsplHost.FormClosed += new FormClosedEventHandler(Game_close);
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            //Checks if user has internet
            if (!CheckOnInternetConnection())
            {
                txtError.Text = "There was an error while trying to join LAN game!";
                return;
            }

            //Runs a LAN client game
            host_join = fieldIPJoin.Text;
            port_join = fieldPortJoin.Text;
            LANPlvsPlClient Client = new LANPlvsPlClient();
            Client.Show();

            txtError.Text = "";

            Hide();
            Client.FormClosed += new FormClosedEventHandler(Game_close);
        }
        private bool CheckOnInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Game_close(object sender, FormClosedEventArgs e)
        {
            if(close == "host disconnected")
            {
                txtError.Text= "The host disconnected!";
            }
            Show();
        }


    }
}
