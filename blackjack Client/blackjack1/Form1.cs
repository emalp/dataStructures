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
using System.Net.Sockets;
using System.IO;

namespace blackJack1
{

    /// <summary>
    /// This is the Client application for the blackJack game coded as our diploma project.
    /// <Title>Client BlackJack </Title>
    /// <mainBody>
    /// 
    /// How to Play
    /// ----------
    /// 
    /// Just connect to the server once you open the application.
    /// The click on either hit or stick to hit or stick in the blackjack.
    /// </mainBody>
    /// 
    /// <costumisation>
    ///   
    ///  Costumisation:
    ///  ------------
    /// 
    /// You can change the user constumisation by selecting the prefered theme for you while... 
    /// playing the game.
    /// </costumisation>
    /// 
    /// 
    /// <Bugs>
    /// Current Bugs:
    /// -----------
    /// 
    /// The images sometimes are not imported and displayed while connecting to the server 
    /// and the application crashes and you'll have to restart the client.
    /// 
    /// </Bugs>
    /// </summary>
    /// 
    public partial class Client : Form
    {

        hashMap hm;
        int port = 9090;
        String server = "";
        Boolean isConnected = false;
        TcpClient client;
        int playerCardSum;
        int dealerCardSum;
        PictureBox[] clientboxes = new PictureBox[6];
        PictureBox[] serverboxes = new PictureBox[6];
        String msg = "";
        String[] frontFace = {"clubs", "diamonds", "spades", "hearts" };
        int curPicBoxClient = 2, curPicBoxServer = 2;

        public Client()
        {
            InitializeComponent();
        }
        public void initializeHashMap() {
            hm = new hashMap(4);
            hm.add("1", "ace");
            hm.add("11", "jack");
            hm.add("12", "queen");
            hm.add("13", "king");
        }

        /// <summary>
        /// Run all the thing when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            darkTheme.Checked = true;

            initializeHashMap();

            clientboxes[0] = pictureBox1;
            clientboxes[1] = pictureBox3;
            clientboxes[2] = pictureBox4;
            clientboxes[3] = pictureBox5;
            clientboxes[4] = pictureBox7;
            clientboxes[5] = pictureBox13;

            serverboxes[0] = pictureBox2;
            serverboxes[1] = pictureBox8;
            serverboxes[2] = pictureBox9;
            serverboxes[3] = pictureBox10;
            serverboxes[4] = pictureBox11;
            serverboxes[5] = pictureBox12;

            for (int x = 0; x <= 5; x++) {
                clientboxes[x].SizeMode = PictureBoxSizeMode.StretchImage;
                serverboxes[x].SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //pictureBox1.ImageLocation = @"Z:\Projects\CSharp\images\playing-cards-assets-master\png\2_of_hearts.png";
            //pictureBox1.ImageLocation = @"\png\2_of_hearts.png"; this has to be correct
            // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // pictureBox1.BackColor = Color.White;

            mainpanel.Enabled = false;
            disconnectBtn.Enabled = false;

            hitBtn.Enabled = false;
            stickBtn.Enabled = false;

        }

        /// <summary>
        /// Connect and disconnect to and from the server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void disconnectBtn_Click(object sender, EventArgs e)
        {

            String totalval = "*";

            ASCIIEncoding asen = new ASCIIEncoding();
            NetworkStream stm = client.GetStream();
            byte[] ba = asen.GetBytes(totalval);

            stm.Write(ba, 0, ba.Length);
            stm.Flush();
            MessageBox.Show("Client disconnected from server!");

            client.Close();
            this.Close();
            Client f = new Client();
            f.Show();
           
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            servText.Enabled = false;
            string servIP = servText.Text;
            if (!(servIP == null))
            {
                server = servIP;
                try
                {
                    client = new TcpClient();
                    client.Connect(servIP, port);
                    statusLbl.Text = "Connected to server. Ready to play!";
                    isConnected = true;
                    MessageBox.Show("Client Connected to server. Ready to play!");
                }
                catch (Exception ex) {
                    isConnected = false;
                    MessageBox.Show(ex.Message);
                }


                if (isConnected) {
                    connectBtn.Enabled = false;
                    mainpanel.Visible = true;
                    mainpanel.Enabled = true;
                    disconnectBtn.Enabled = true;
                    hitBtn.Enabled = true;
                    stickBtn.Enabled = true;

                    // recieve initial cards now
                    ReceiveInitialCards();
                }
            }
            else {
                MessageBox.Show("You can't enter null as server IP");
            }
        }

        /// <summary>
        /// The method runs when the hit button is click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returnVal>
        /// The method returns 2 random cards from the server and puts one on the client...
        /// and another is set to the server card.
        /// </returnVal>


        private void hitBtn_Click(object sender, EventArgs e)
        {
            int times = 2;

            for (int z = 0; z < times; z++)
            {
                String ini = ">";

                ASCIIEncoding asen = new ASCIIEncoding();
                NetworkStream stm = client.GetStream();
                byte[] ba = asen.GetBytes(ini);

                stm.Write(ba, 0, ba.Length);
                stm.Flush();

                byte[] b = new byte[1024];
                int x = stm.Read(b, 0, b.Length);
                stm.Flush();

                char[] v = new char[x + 1];
                //Console.WriteLine("Recieved int: " + j + " bytes");

              //  Console.WriteLine("String : ");
                for (int i = 0; i <= x; i++)
                {
                    v[i] = Convert.ToChar(b[i]);
                }
                String card = v[0].ToString();//new String(v);
                int cardVal = Int32.Parse(card); // cardVal has the card got by client
                                                 //  MessageBox.Show("Recieved: " + card);
                if (cardVal == 1 || cardVal > 10)
                {
                    card = hm.get(card);
                  //MessageBox.Show(card);
                }

                if (z == 0)
                {
                    int allfaces = frontFace.Length;
                    Random r = new Random();
                    int frontFaceIndex = r.Next(0, allfaces - 1);
                    String face = frontFace[frontFaceIndex];
                    

                    clientboxes[curPicBoxClient].ImageLocation = @"png\" + card + "_of_" + face + ".png";
                    //     MessageBox.Show(pictureBox1.ImageLocation);// "/png/" + card1 +  ".png");
                    clientboxes[curPicBoxClient].SizeMode = PictureBoxSizeMode.StretchImage;
                    clientboxes[curPicBoxClient].BackColor = Color.White;
                    // THE FREAKING IMAGE DOESNT SHOW UPPP!!!

                    curPicBoxClient++;
                    playerCardSum += cardVal;
                    Boolean err = CalculatePlayerSum();
                    if (err) { break; }
                }
                else {
                    int allfaces = frontFace.Length;
                    Random r = new Random();
                    int frontFaceIndex = r.Next(0, allfaces - 1);
                    String face = frontFace[frontFaceIndex];

                    serverboxes[curPicBoxServer].ImageLocation = @"png\" + card + "_of_" + face + ".png";
                    //     MessageBox.Show(pictureBox1.ImageLocation);// "/png/" + card1 +  ".png");
                    serverboxes[curPicBoxServer].SizeMode = PictureBoxSizeMode.StretchImage;
                    serverboxes[curPicBoxServer].BackColor = Color.White;
                    // THE FREAKING IMAGE DOESNT SHOW UPPP!!!

                    curPicBoxServer++;
                    dealerCardSum += cardVal;
                    Boolean err = CalculateDealerSum();
                    if (err) { break; }
                }
            }

        }



        /// <summary>
        /// This method receives initial 4 cards from the server
        /// 
        /// <returnValue>
        /// The return value from this method are 4 cards.
        /// Two random cards for the client.
        /// Two random cards for the server.
        /// 
        /// </returnValue>
        /// </summary>
        public void ReceiveInitialCards() {
           // MessageBox.Show("in the recieve initial cards method");
            ASCIIEncoding asen = new ASCIIEncoding();
            NetworkStream stm = client.GetStream();
            int clcard1 = 0, clcard2 = 0, dlrcard1 = 0, dlrcard2 = 0;

            byte[] b = new byte[2048];
            int x = stm.Read(b, 0, b.Length); // here
            char[] v = new char[x + 1];
            for (int i = 0; i <= x; i++)
            {

                v[i] = Convert.ToChar(b[i]);
            }

            String allCards = new String(v); // allcards has 4 cards separated by space
            char[] spaceSeparator = new char[] { ' ' };
           // MessageBox.Show(allCards);
            String[] cards = allCards.Split(spaceSeparator);

            clcard1 = Int32.Parse(cards[1]);
            clcard2 = Int32.Parse(cards[2]);
            dlrcard1 = Int32.Parse(cards[3]);
            dlrcard2 = Int32.Parse(cards[4]);

            int allfaces = frontFace.Length;
            Random r = new Random();
            int frontFaceIndex = r.Next(0, allfaces-1);
            String face = frontFace[frontFaceIndex];

            // image locations of the picture boxes..
            if (clcard1 == 1 || clcard1 > 10) {
             
                cards[1] = hm.get(cards[1].ToString());
            }
            clientboxes[0].ImageLocation = @"png\" + cards[1] + "_of_" + face + ".png";
            clientboxes[0].BackColor = Color.White;
            // -- clbox1

            frontFaceIndex = r.Next(0, allfaces - 1);
            face = frontFace[frontFaceIndex];
            if (clcard2 == 1 || clcard2 > 10)
            {
                cards[2] = hm.get(cards[2].ToString());
            }
            clientboxes[1].ImageLocation = @"png\" + cards[2] + "_of_" + face + ".png";
            clientboxes[1].BackColor = Color.White;
            // -- clbox2

            frontFaceIndex = r.Next(0, allfaces - 1);
            face = frontFace[frontFaceIndex];
            if (dlrcard1 == 1 || dlrcard1 > 10)
            {
                cards[3] = hm.get(cards[3].ToString());
            }
            serverboxes[0].ImageLocation = @"png\" + cards[3] + "_of_" + face + ".png";
            serverboxes[0].BackColor = Color.White;
            // -- dlrbox1

            frontFaceIndex = r.Next(0, allfaces - 1);
            face = frontFace[frontFaceIndex];
            if (dlrcard2 == 1 || dlrcard2 > 10)
            {
                cards[4] = hm.get(cards[4].ToString());
            }
            serverboxes[1].ImageLocation = @"png\" + cards[4][0] + "_of_" + face + ".png";
            serverboxes[1].BackColor = Color.White;
            // -- dlrbox2

            playerCardSum += clcard1;
            playerCardSum += clcard2;

            dealerCardSum += dlrcard1;
            dealerCardSum += dlrcard2;

            CalculatePlayerSum();
            CalculateDealerSum();

        }


        /// <summary>
        /// The two methods below keep track of the current sum of both server and...
        /// the client cards to decide who loses or wins first...
        /// to display the onPaint method to the client.
        /// </summary>
        /// <returns> Returns a onPaint method into the window screen. </returns>
        public Boolean CalculateDealerSum() {
            if (dealerCardSum == 21)
            {
                MessageBox.Show("Dealer got blackjack " + dealerCardSum);
                return false;
            }
            else if (dealerCardSum > 21)
            {
                MessageBox.Show("You won! " + dealerCardSum);
                msg = "You Won!";
                winnerStage.Dock = DockStyle.Fill;
                winnerStage.BackColor = Color.White;
                winnerStage.Paint += new System.Windows.Forms.PaintEventHandler(this.winnerStage_Paint);
                mainpanel.Enabled = false;
                return true;
                //client.Close();
                // Form1 f = new Form1();
                // f.Show();
                // this.Close();

            }
            else {
                // do nothing
              //  MessageBox.Show("Dealers fine " + dealerCardSum);
                return false;
            }

        }

        public Boolean CalculatePlayerSum() {

            if (playerCardSum == 21)
            {
                MessageBox.Show("You got BlackJack! " + playerCardSum);
                return false;
            }
            else if (playerCardSum > 21)
            {
                MessageBox.Show("You lost! " + playerCardSum);
                msg = "You lost!";
                winnerStage.Dock = DockStyle.Fill;
                winnerStage.BackColor = Color.White;
                winnerStage.Paint += new System.Windows.Forms.PaintEventHandler(this.winnerStage_Paint);
                mainpanel.Enabled = false;
                return true;
              //  client.Close();
              //  Form1 f = new Form1();
              //  f.Show();
               // this.Close();

            }
            else {
                // do nothing
              //  MessageBox.Show("Youre fine " + playerCardSum);
                return false;
               
            }

        }

        /// <summary>
        /// This method does the "stand" command in blackJack
        /// 
        /// <returnVal>
        /// It returns only one card and places it into as one of the server's cards.
        /// </returnVal>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void stickBtn_Click(object sender, EventArgs e)
        {
            String ini = ">";

            ASCIIEncoding asen = new ASCIIEncoding();
            NetworkStream stm = client.GetStream();
            byte[] ba = asen.GetBytes(ini);

            stm.Write(ba, 0, ba.Length);
            stm.Flush();

            byte[] b = new byte[1024];
            int x = stm.Read(b, 0, b.Length);
            stm.Flush();

            char[] v = new char[x + 1];
            //Console.WriteLine("Recieved int: " + j + " bytes");

            //  Console.WriteLine("String : ");
            for (int i = 0; i <= x; i++)
            {
                v[i] = Convert.ToChar(b[i]);
            }
            String card = v[0].ToString();//new String(v);
            int cardVal = Int32.Parse(card); // cardVal has the card got by client
                                             //  MessageBox.Show("Recieved: " + card);
            if (cardVal == 1 || cardVal > 10)
            {
                card = hm.get(card);
                //MessageBox.Show(card);
            }

            int allfaces = frontFace.Length;
            Random r = new Random();
            int frontFaceIndex = r.Next(0, allfaces - 1);
            String face = frontFace[frontFaceIndex];

            serverboxes[curPicBoxServer].ImageLocation = @"png\" + card + "_of_" + face + ".png";
            //     MessageBox.Show(pictureBox1.ImageLocation);// "/png/" + card1 +  ".png");
            serverboxes[curPicBoxServer].SizeMode = PictureBoxSizeMode.StretchImage;
            serverboxes[curPicBoxServer].BackColor = Color.White;
            // THE FREAKING IMAGE DOESNT SHOW UPPP!!!

            curPicBoxServer++;
            dealerCardSum += cardVal;
            CalculateDealerSum();
            
        }

        private void lightTheme_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }


        /// <summary>
        /// This method paints lose or win into the client's window screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void winnerStage_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 25);

            // Draw a string on the PictureBox.
            g.DrawString(msg,
                f, System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            g.DrawLine(System.Drawing.Pens.Red, winnerStage.Left, winnerStage.Top,
                winnerStage.Right, winnerStage.Bottom);
        }

    }
}
