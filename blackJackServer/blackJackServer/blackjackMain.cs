using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace blackJackServer
{

    /// <summary>
    /// This is the Server application for the blackJack game coded as our diploma project.
    /// <Title>Client BlackJack </Title>
    /// <mainBody>
    /// 
    /// How to Play
    /// ----------
    /// 
    /// Just open the server application to start the server.
    /// Then server starts listening on port 9090 automatically waiting for any client to...
    /// connect and play!
    /// </mainBody>
    /// 
    /// 
    /// 
    /// <Bugs>
    /// There are no current known bugs in the server application.
    /// </Bugs>
    /// </summary>

    class blackjackMain
    {
        int port = 9090;
       
        IPAddress address;
        TcpListener server;
        Socket s;

        byte[] b = new byte[1024];

        public blackjackMain() {
            try
            {
               
                address = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(address, port);

                server.Start(); // started listening at port 9090
                Console.WriteLine("Server started on port " + port);

                s = server.AcceptSocket();
                Console.WriteLine("A Player connected to server!..");


                // do money calculation first.
                SendInitialCards();
                //getFromClient();
              
                s.Close();
                server.Stop();

            }
            catch (Exception e) {
                //Console.WriteLine("EER:: " + e);
                s.Close();
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine();
                Console.WriteLine("There was an error, restarting server ..");
                server.Stop();
                blackjackMain b = new blackjackMain();
            }

        }

        public void GetFromClient() { // this method will start at first.., it'll start listening clt
            
                
                ReadfromClient();
           
        }


        public void ReadfromClient() {
            try
            {

                int j = s.Receive(b);
                char[] x = new char[j + 1];

                for (int i = 0; i <= j; i++)
                {
                    x[i] = Convert.ToChar(b[i]);

                }


                if (x[0].ToString() == "*")
                { // * means client wants to close connection

                    s.Close();
                    Console.WriteLine("Client has left the game! Restarting server..");
                    server.Stop();
                    blackjackMain b = new blackjackMain();
                }
                else if (x[0].ToString() == ">")
                { // > means hit

                    Console.WriteLine("Client selected hit/ wanted a card!, sending a random card to client");
                    SendRandCard();
                    ReadfromClient();

                }
                else
                {
                    Console.WriteLine("Nope nothing ");
                }
            }
            catch (Exception ex) {
                s.Close();
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("There was an error, restarting server ..");
                server.Stop();
                blackjackMain b = new blackjackMain();
            }
           
        }

        public void SendRandCard() {
            try
            {
                Random rnd = new Random();

                ASCIIEncoding asen = new ASCIIEncoding();

                int card = rnd.Next(1, 13);
                String sendingcard = card.ToString();
                s.Send(asen.GetBytes(sendingcard));
            }
            catch (Exception ex) {
                s.Close();
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("There was an error, restarting server ..");
                server.Stop();
                blackjackMain b = new blackjackMain();
            }

        }

        public void SendInitialCards() {
            try
            {
                Random rnd = new Random();
                String inicard = null;

                ASCIIEncoding asen = new ASCIIEncoding();

                // send all cards
                for (int x = 1; x <= 4; x++)
                {
                    int card = rnd.Next(1, 12);
                    String sendingcard = card.ToString();
                    inicard = inicard + " " + sendingcard;
                }
                s.Send(asen.GetBytes(inicard));
                GetFromClient();
            }
            catch (Exception ex) {
                s.Close();
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("There was an error, restarting server ..");
                server.Stop();
                blackjackMain b = new blackjackMain();
            }
        }


    }
}
