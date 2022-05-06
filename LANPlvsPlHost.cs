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
using System.Collections;

namespace TicTacToe
{

    public partial class LANPlvsPlHost : Form
    {

        //Sets whos roud is
        public static string round = "X";

        private static bool isPlaying = true;

        private static int point_p1 = 0;
        private static int point_p2 = 0;

        public LANPlvsPlHost()
        {
            InitializeComponent();

        }

        SimpleTcpServer server;


        private void btnBack_Click(object sender, EventArgs e)
        {
            //When host ends it will send broadcast message
            server.BroadcastLine("stop");
            server.Stop();
            Close();
        }

        private void LANPlvsPlHost_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //Creates new server
            Start.Visible = false;
            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            //Tries to start the server
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
            txtPlr.Invoke((MethodInvoker)delegate ()
            {
                //When player joins it will allow to start the game
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "2")
                {
                    txtPlr.Text = "Players: 2/2";
                    Start.Visible = true;
                }
                //When player leaves it will disallow to start the game or stop the game
                if(e.MessageString.Remove(e.MessageString.Length - 1) == "1")
                {
                    txtPlr.Text = "Players: 1/2";
                    Starting.Text = "";
                    Start.Visible = false;
                    txtInformation.Visible = true;
                    txtPlr.Visible = true;
                    Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
                    foreach(Button btn in btns)
                    {
                        btn.Visible = false;
                        btn.Text = null;
                    }
                    round = "X";
                    txtRound.Visible = false;
                    isPlaying = true;
                    points.Visible = false;
                    point_p1 = 0;
                    point_p2 = 0;
                    points.Text = "Points: \n" + "Player1[X]: 0 \n Player2[O]: 0"; 
                }

                //When client played his round it will update at host
                if (e.MessageString.Remove(e.MessageString.Length - 1).Contains("place"))
                {
                    round = "X";
                    switch (e.MessageString.Remove(e.MessageString.Length - 1))
                    {
                        case "place1":
                            place1.Text = "O";
                            break;
                        case "place2":
                            place2.Text = "O";
                            break;
                        case "place3":
                            place3.Text = "O";
                            break;
                        case "place4":
                            place4.Text = "O";
                            break;
                        case "place5":
                            place5.Text = "O";
                            break;
                        case "place6":
                            place6.Text = "O";
                            break;
                        case "place7":
                            place7.Text = "O";
                            break;
                        case "place8":
                            place8.Text = "O";
                            break;
                        case "place9":
                            place9.Text = "O";
                            break;
                    }
                    txtRound.Text = "Round: " + round;
                    CheckOnClientWin();
                    OnFullGrid();
                }
            });
            
        }

        private void LANPlvsPlHost_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When host ends it will send broadcast message
            server.BroadcastLine("stop");
            server.Stop();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //When host click start it will start the game and make grid visible
            server.BroadcastLine("start");
            Start.Visible = false;
            Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
            foreach (Button btn in btns)
            { 
                btn.Visible = true;
            }
            txtInformation.Visible = false;
            txtPlr.Visible = false;
            txtRound.Visible = true;
            txtRound.Text = "Round: " + round;
            points.Visible = true;
        }

        private bool OnFullGrid()
        {
            //Checks if grid is full
            if(place1.Text != "" && place2.Text != "" && place3.Text != "" && place4.Text != "" && place5.Text != "" && place6.Text != "" && place7.Text != "" && place8.Text != "" && place9.Text != "")
            {
                server.BroadcastLine("tie");
                isPlaying = false;
                txtGameEnd.Text = "Tie!";
                btnPlayAgain.Visible = true;
                txtRound.Visible = false;
                return true;
            }
            return false;
        }
        private void CheckOnClientWin()
        {
            //Checks if client win in any scenario
            if (place1.Text == "O" && place2.Text == "O" && place3.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place4.Text == "O" && place5.Text == "O" && place6.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place7.Text == "O" && place8.Text == "O" && place9.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place1.Text == "O" && place4.Text == "O" && place7.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place2.Text == "O" && place5.Text == "O" && place8.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place3.Text == "O" && place6.Text == "O" && place9.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place1.Text == "O" && place5.Text == "O" && place9.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else if (place3.Text == "O" && place5.Text == "O" && place7.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
                btnPlayAgain.Visible = true;
            }
            else
            {
                return;
            }
            point_p2++;
            points.Text = "Points: \n" + 
                          "Player1[X]: " + point_p1 + "\n" + 
                          "Player2[O]: " + point_p2;
        }

        private void OnGridClick(object sender, EventArgs e)
        {
            Button click = sender as Button;
            //Will put mark on grid and change the round
            if (round == "X" && click.Text == "" && isPlaying == true) {
                
                server.BroadcastLine(click.Name);
                click.Text = round;
                round = "O";
                txtRound.Text = "Round: " + round;
                OnFullGrid();
            }
            CheckOnPlayer1Win();

        }

        private void CheckOnPlayer1Win()
        {
            if(place1.Text == "X" && place2.Text == "X" && place3.Text == "X")
            {  
                //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place4.Text == "X" && place5.Text == "X" && place6.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place7.Text == "X" && place8.Text == "X" && place9.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place1.Text == "X" && place4.Text == "X" && place7.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place2.Text == "X" && place5.Text == "X" && place8.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place3.Text == "X" && place6.Text == "X" && place9.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place1.Text == "X" && place5.Text == "X" && place9.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place3.Text == "X" && place5.Text == "X" && place7.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                btnPlayAgain.Visible = true;
                isPlaying = false;
                txtRound.Visible = false;
            }
            else
            {
                return;
            }
            point_p1++;
            points.Text = "Points: \n" +
                          "Player1[X]: " + point_p1 + "\n" +
                          "Player2[O]: " + point_p2;

        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            txtGameEnd.Text = null;
            btnPlayAgain.Visible = false;
            isPlaying = true;
            //When play again button is clicked it will reset the game
            Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
            foreach (Button btn in btns)
            {
                btn.Text = null;
            }
            txtRound.Visible = true;
            server.BroadcastLine("again");
        }

        private void TxtGameEnd_Enter(object sender, EventArgs e)
        {
            place1.Focus();
        }

        private void txtRound_Click(object sender, EventArgs e)
        {

        }
    }
}
