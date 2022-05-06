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

        private static bool isPlaying = true;

        private static int point_p1 = 0;
        private static int point_p2 = 0;

        private void LANPlvsPlClient_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
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

                //When game end a tie
                if (e.MessageString.Remove(e.MessageString.Length - 1).Contains("tie"))
                {
                    txtGameEnd.Text = "Tie!";
                    txtRound.Visible = false;
                    isPlaying = false;
                    Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
                    foreach (Button btn in btns)
                    {
                        if (btn.Text == "X")
                        {
                            btn.Text = "X";
                        }
                    }
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
                    CheckOnHostWin();
                    return;
                }
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
                    points.Visible = true;
                    return;
                }
                //When host leaves it will close client and display an error message
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "stop")
                {
                    client.Disconnect();
                    CreateOrJoinLan.close = "host disconnected";
                    Close();
                    return;
                }
                //When host click play again button
                if (e.MessageString.Remove(e.MessageString.Length - 1) == "again")
                {
                    txtGameEnd.Text = null;
                    isPlaying = true;
                    //When play again button is clicked it will reset the game
                    Button[] btns = { place1, place2, place3, place4, place5, place6, place7, place8, place9 };
                    foreach (Button btn in btns)
                    {
                        btn.Text = null;
                    }
                    txtRound.Visible = true;
                    return;
                }
                
            });

        }

        private void OnGridClick(object sender, EventArgs e)
        {
            Button click = sender as Button;
            //Will put mark on grid and change the round
            if (round == "O" && click.Text == "" && isPlaying == true)
            {
               
                client.WriteLine(click.Name);
                click.Text = round;
                round = "X";
                txtRound.Text = "Round: " + round;
                CheckOnClientWin();
            }
        }
        private void CheckOnHostWin()
        {
            if (place1.Text == "X" && place2.Text == "X" && place3.Text == "X")
            {
                //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place4.Text == "X" && place5.Text == "X" && place6.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place7.Text == "X" && place8.Text == "X" && place9.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place1.Text == "X" && place4.Text == "X" && place7.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place2.Text == "X" && place5.Text == "X" && place8.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place3.Text == "X" && place6.Text == "X" && place9.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place1.Text == "X" && place5.Text == "X" && place9.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place3.Text == "X" && place5.Text == "X" && place7.Text == "X")
            { //Checks if host win in any scenario
                txtGameEnd.Text = "Player1 WIN!";
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
        private void CheckOnClientWin()
        {
            //Checks if client win in any scenario
            if (place1.Text == "O" && place2.Text == "O" && place3.Text == "O")
            {
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place4.Text == "O" && place5.Text == "O" && place6.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place7.Text == "O" && place8.Text == "O" && place9.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place1.Text == "O" && place4.Text == "O" && place7.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place2.Text == "O" && place5.Text == "O" && place8.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place3.Text == "O" && place6.Text == "O" && place9.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place1.Text == "O" && place5.Text == "O" && place9.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
            }
            else if (place3.Text == "O" && place5.Text == "O" && place7.Text == "O")
            { 
                txtGameEnd.Text = "Player2 WIN!";
                isPlaying = false;
                txtRound.Visible = false;
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
        private void BtnBack_Click(object sender, EventArgs e)
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

        private void TxtGameEnd_Enter(object sender, EventArgs e)
        {
            place1.Focus();
        }
    }
}
