using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SimpleTCP;

namespace TicTacToe
{
    public partial class LANPlvsPlHost : Form
    {
        public LANPlvsPlHost()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;


        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LANPlvsPlHost_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            try
            {
                server.Start(IPAddress.Parse(Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString()), Convert.ToInt32(CreateOrJoinLan.port));
                txtInformation.Text = " IP: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString() +
                    "\n Hostname: " + Dns.GetHostName() +
                    "\n Port: " + CreateOrJoinLan.port;
            }
            catch
            {
                txtPlr.Text = "Couldn't connect";
                txtInformation.Text = " IP: Couldn't connect" +
                    "\n Hostname: Couldn't connect" +
                    "\n Port: Couldn't connect";
            }
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            if(e.MessageString == "2")
            {
                txtPlr.Text = "Players: 2/2";
            }
        }

        private void LANPlvsPlHost_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Stop();
        }
    }
}
