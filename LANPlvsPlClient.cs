using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;

namespace TicTacToe
{
    public partial class LANPlvsPlClient : Form
    {
        public LANPlvsPlClient()
        {
            InitializeComponent();

        }

        SimpleTcpClient client;

        public string round = "X";

        private void LANPlvsPlClient_Load(object sender, EventArgs e)
        {
            //Creates new client and tries to join server
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
            try
            {
                client.Connect(CreateOrJoinLan.host_join, Convert.ToInt32(CreateOrJoinLan.port_join));
                txtPlr.Text = "Players: 2/2";
                txtInformation.Text = "IP: " + CreateOrJoinLan.host_join +
                    "\nPort: " + Convert.ToInt32(CreateOrJoinLan.port_join);
                client.WriteLine("2");
            }catch
            {
                txtPlr.Text = "Couldn't connect";
                txtInformation.Text = " IP: Couldn't connect" +
                    "\n Port: Couldn't connect";
            }
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtPlr.Invoke((MethodInvoker)delegate ()
            {
                //When the host started game grid will become visible
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "start")
                {
                    Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
                    foreach (Button btn in btns)
                    {
                        btn.Visible = true;
                    }
                    txtInformation.Visible = false;
                    txtPlr.Visible = false;
                    txtRound.Visible = true;
                    txtRound.Text = "Round: " + round;
                }
                //When host leaves it will close client and display an error message
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "stop")
                {
                    client.Disconnect();
                    CreateOrJoinLan.close = "host disconnected";
                    Close();
                }
                //When host played his round it will update at client
                if (e.MessageString.Remove(e.MessageString.Length - 1).Contains("place"))
                {
                    round = "O";
                    switch (e.MessageString.Remove(e.MessageString.Length - 1))
                    {
                        case "place1":
                            place1.Text = "X";
                            break;
                        case "place2":
                            place2.Text = "X";
                            break;
                        case "place3":
                            place3.Text = "X";
                            break;
                        case "place4":
                            place4.Text = "X";
                            break;
                        case "place5":
                            place5.Text = "X";
                            break;
                        case "place6":
                            place6.Text = "X";
                            break;
                        case "place7":
                            place7.Text = "X";
                            break;
                        case "place8":
                            place8.Text = "X";
                            break;
                        case "place9":
                            place9.Text = "X";
                            break;
                    }
                    txtRound.Text = "Round: " + round;
                }
                //When game end a tie
                if (e.MessageString.Remove(e.MessageString.Length - 1).Contains("tie"))
                {
                    txtGameEnd.Text = "Tie!";
                    txtRound.Visible = false;
                    Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
                    foreach (Button btn in btns)
                    {
                        if (btn.Text == "") 
                        {
                            btn.Text = "X";
                        }
                    }
                }
                //When host click play again button
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "again")
                {
                    txtGameEnd.Text = null;
                    //When play again button is clicked it will reset the game
                    Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
                    foreach (Button btn in btns)
                    {
                        btn.Text = null;
                    }
                    txtRound.Visible = true;

                }
            });
        }

        private void OnGridClick(object sender, EventArgs e)
        {
            if (onFullGrid()) return;
            Button click = sender as Button;
            //Will put mark on grid and change the round
            if (round == "O" && click.Text == "")
            {
               
                client.WriteLine(click.Name);
                click.Text = round;
                round = "X";
                txtRound.Text = "Round: " + round;
            }
        }
        private bool onFullGrid()
        {
            //Checks if grid is full
            if (place1.Text != "" && place2.Text != "" && place3.Text != "" && place4.Text != "" && place5.Text != "" && place6.Text != "" && place7.Text != "" && place8.Text != "" && place9.Text != "")
            {
                txtGameEnd.Text = "Tie!";
                return true;
            }
            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //It will close the window
            try
            {
                client.WriteLine("1");
                client.Disconnect();
            }
            catch
            {

            }
            Close();
        }

        private void LANPlvsPlClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //It will close the window
            try
            {
                client.WriteLine("1");
                client.Disconnect();
            }
            catch
            {

            }
        }
    }
}
